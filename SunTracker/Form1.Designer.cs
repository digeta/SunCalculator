namespace SunTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtGmt = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblEot = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTimeCor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHra = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAlti = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAzi = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRise = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "dt GMT :";
            // 
            // txtGmt
            // 
            this.txtGmt.Location = new System.Drawing.Point(251, 54);
            this.txtGmt.Name = "txtGmt";
            this.txtGmt.Size = new System.Drawing.Size(65, 20);
            this.txtGmt.TabIndex = 1;
            this.txtGmt.Text = "2";
            this.txtGmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(93, 20);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(65, 20);
            this.txtLat.TabIndex = 3;
            this.txtLat.Text = "41";
            this.txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Latitude  :";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(93, 54);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(65, 20);
            this.txtLong.TabIndex = 5;
            this.txtLong.Text = "31";
            this.txtLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Longtitude :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Day Number :";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(222, 17);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(145, 20);
            this.datePicker.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(397, 15);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(90, 106);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(10, 13);
            this.lblDays.TabIndex = 11;
            this.lblDays.Text = "-";
            // 
            // lblEot
            // 
            this.lblEot.AutoSize = true;
            this.lblEot.Location = new System.Drawing.Point(90, 135);
            this.lblEot.Name = "lblEot";
            this.lblEot.Size = new System.Drawing.Size(10, 13);
            this.lblEot.TabIndex = 13;
            this.lblEot.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "EoT :";
            // 
            // lblTimeCor
            // 
            this.lblTimeCor.AutoSize = true;
            this.lblTimeCor.Location = new System.Drawing.Point(90, 164);
            this.lblTimeCor.Name = "lblTimeCor";
            this.lblTimeCor.Size = new System.Drawing.Size(10, 13);
            this.lblTimeCor.TabIndex = 15;
            this.lblTimeCor.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Time Corr. :";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Location = new System.Drawing.Point(90, 193);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(10, 13);
            this.lblDec.TabIndex = 17;
            this.lblDec.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Declination :";
            // 
            // lblHra
            // 
            this.lblHra.AutoSize = true;
            this.lblHra.Location = new System.Drawing.Point(90, 222);
            this.lblHra.Name = "lblHra";
            this.lblHra.Size = new System.Drawing.Size(10, 13);
            this.lblHra.TabIndex = 19;
            this.lblHra.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Hour Angle :";
            // 
            // lblAlti
            // 
            this.lblAlti.AutoSize = true;
            this.lblAlti.Location = new System.Drawing.Point(90, 251);
            this.lblAlti.Name = "lblAlti";
            this.lblAlti.Size = new System.Drawing.Size(10, 13);
            this.lblAlti.TabIndex = 21;
            this.lblAlti.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Altitude :";
            // 
            // lblAzi
            // 
            this.lblAzi.AutoSize = true;
            this.lblAzi.Location = new System.Drawing.Point(90, 280);
            this.lblAzi.Name = "lblAzi";
            this.lblAzi.Size = new System.Drawing.Size(10, 13);
            this.lblAzi.TabIndex = 23;
            this.lblAzi.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Azimuth :";
            // 
            // lblRise
            // 
            this.lblRise.AutoSize = true;
            this.lblRise.Location = new System.Drawing.Point(90, 309);
            this.lblRise.Name = "lblRise";
            this.lblRise.Size = new System.Drawing.Size(10, 13);
            this.lblRise.TabIndex = 25;
            this.lblRise.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 309);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Sunrise :";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Location = new System.Drawing.Point(90, 338);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(10, 13);
            this.lblSet.TabIndex = 27;
            this.lblSet.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 338);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Sunset :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 378);
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblRise);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblAzi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblAlti);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblHra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTimeCor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGmt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGmt;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblEot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTimeCor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblHra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAlti;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAzi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRise;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.Label label21;
    }
}

