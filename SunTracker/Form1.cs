using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunTracker
{    
    public partial class Form1 : Form
    {
        private int[] months = new int[12]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private double rad = Math.PI / 180.0d;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            datePicker.CustomFormat = "dd-MM-yyyy hh:mm:ss";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                PosData posData = new PosData();

                posData.Latitude = Convert.ToDouble(txtLat.Text);
                posData.Longtitude = Convert.ToDouble(txtLong.Text);

                posData.DtGMT = Convert.ToInt32(txtGmt.Text);
                posData.Date = datePicker.Value;

                Calculate(posData);
                PrintScr(posData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void Calculate(PosData posData)
        {
            int year = posData.Date.Year;
            int month = posData.Date.Month;
            int day = posData.Date.Day;

            double hour = Convert.ToDouble(posData.Date.Hour);
            double minute = Convert.ToDouble(posData.Date.Minute);

            if(CheckLeap(year)) months[1] = 29;

            for (int i = 0; i < month - 1; i++ )
            {
                posData.Days = posData.Days + months[i];
            }

            posData.Days = posData.Days + day;

            posData.LSTM = 15 * posData.DtGMT;
            posData.B = Math.Round((posData.Days - 81) * (360d / 365d), 4, MidpointRounding.AwayFromZero);

            double eot_1 = 0;
            double eot_2 = 0;
            double eot_3 = 0;

            double degRad = posData.B * rad;

            eot_1 = Math.Round((9.87 * 2 * Math.Sin(degRad) * Math.Cos(degRad)), 4, MidpointRounding.AwayFromZero);
            eot_2 = Math.Round((-7.53 * Math.Cos(degRad)), 4, MidpointRounding.AwayFromZero);
            eot_3 = Math.Round((-1.5 * Math.Sin(degRad)), 4, MidpointRounding.AwayFromZero);

            posData.EoT = Math.Round((eot_1 + eot_2 + eot_3), 2, MidpointRounding.AwayFromZero);
            posData.TC = Math.Round((4 * (posData.Longtitude - posData.LSTM) + posData.EoT), 2, MidpointRounding.AwayFromZero);
            
            posData.LT = Math.Round((hour + (minute / 60d)), 4, MidpointRounding.AwayFromZero);
            posData.LST = Math.Round((posData.LT + (posData.TC / 60d)), 4, MidpointRounding.AwayFromZero);
            posData.HRA = Math.Round((15 * (posData.LST - 12d)), 2, MidpointRounding.AwayFromZero);

            posData.Declination = Math.Round((23.45d * Math.Sin(degRad)), 2, MidpointRounding.AwayFromZero);

            double degRadDec = posData.Declination * rad;
            double degRadLat = posData.Latitude * rad;
            double degRadHra = posData.HRA * rad;

            double elev_1 = 0;
            double elev_2 = 0;
            double elev = 0;

            elev_1 = Math.Round((Math.Sin(degRadDec) * Math.Sin(degRadLat)), 4, MidpointRounding.AwayFromZero);
            elev_2 = Math.Round((Math.Cos(degRadDec) * Math.Cos(degRadLat) * Math.Cos(degRadHra)), 4, MidpointRounding.AwayFromZero);
            elev = elev_1 + elev_2;

            posData.Elevation = Math.Round(((Math.Asin(elev) * 180d) / Math.PI), 2, MidpointRounding.AwayFromZero);


            double azi_1 = 0;
            double azi_2 = 0;
            double azi_3 = 0;
            double azi = 0;
            double degRadElev = posData.Elevation * rad;

            azi_1 = Math.Round((Math.Sin(degRadDec) * Math.Cos(degRadLat)), 4, MidpointRounding.AwayFromZero);
            azi_2 = Math.Round((-1d * Math.Cos(degRadDec) * Math.Sin(degRadLat) * Math.Cos(degRadHra)), 4, MidpointRounding.AwayFromZero);
            azi_3 = azi_1 + azi_2;
            azi = Math.Round((azi_3 / Math.Cos(degRadElev)), 4, MidpointRounding.AwayFromZero);

            posData.Azimuth = Math.Round((360 - (Math.Acos(azi) * 180d) / Math.PI), 2, MidpointRounding.AwayFromZero);

            //MessageBox.Show(posData.Days.ToString());
        }

        private void PrintScr(PosData posData)
        {
            lblAlti.Text = Convert.ToString(posData.Elevation);
            lblAzi.Text = Convert.ToString(posData.Azimuth);
            lblDays.Text = Convert.ToString(posData.Days);
            lblDec.Text = Convert.ToString(posData.Declination);
            lblEot.Text = Convert.ToString(posData.EoT);
            lblHra.Text = Convert.ToString(posData.HRA);
            lblRise.Text = Convert.ToString(posData.Sunrise);
            lblSet.Text = Convert.ToString(posData.Sunset);
            lblTimeCor.Text = Convert.ToString(posData.TC);
        }

        private bool CheckLeap(int year)
        {
            if (year % 400 == 0)
                return true;
            else if (year % 100 == 0)
                return false;
            else if (year % 4 == 0)
                return true;
            else
                return false;
        }
    }
}
