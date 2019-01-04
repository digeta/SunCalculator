using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunTracker
{
    public class PosData
    {
        private int lstm = 0; // Local Standart Time Meridian
        private int dtGMT = 0; // GMT + 2
        private int days = 0;

        private double b = 0;
        private double eot = 0; // Equation of Time        
        private double tc = 0; // Time Correction factor
        private double lt = 0; // Local Time
        private double lst = 0; // Local Solar Time
        private double hra = 0; // Hour Angle
        private double declination = 0;


        private double azimuth = 0;
        private double elevation = 0;

        private double latitude = 0;
        private double longtitude = 0;

        private DateTime date;
        private DateTime sunrise;
        private DateTime sunset;

        public Double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
            }
        }

        public Double Longtitude
        {
            get
            {
                return longtitude;
            }
            set
            {
                longtitude = value;
            }
        }

        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public DateTime Sunrise
        {
            get
            {
                return sunrise;
            }
            set
            {
                sunrise = value;
            }
        }

        public DateTime Sunset
        {
            get
            {
                return sunset;
            }
            set
            {
                sunset = value;
            }
        }

        public int DtGMT
        {
            get
            {
                return dtGMT;
            }
            set
            {
                dtGMT = value;
            }
        }

        public int LSTM
        {
            get
            {
                return lstm;
            }
            set
            {
                lstm = value;
            }
        }

        public Double LST
        {
            get
            {
                return lst;
            }
            set
            {
                lst = value;
            }
        }

        public Double LT
        {
            get
            {
                return lt;
            }
            set
            {
                lt = value;
            }
        }

        public Double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public Double EoT
        {
            get
            {
                return eot;
            }
            set
            {
                eot = value;
            }
        }

        public Double TC
        {
            get
            {
                return tc;
            }
            set
            {
                tc = value;
            }
        }

        public Double HRA
        {
            get
            {
                return hra;
            }
            set
            {
                hra = value;
            }
        }

        public Double Declination
        {
            get
            {
                return declination;
            }
            set
            {
                declination = value;
            }
        }

        public Double Azimuth
        {
            get
            {
                return azimuth;
            }
            set
            {
                azimuth = value;
            }
        }

        public Double Elevation
        {
            get
            {
                return elevation;
            }
            set
            {
                elevation = value;
            }
        }
    }
}
