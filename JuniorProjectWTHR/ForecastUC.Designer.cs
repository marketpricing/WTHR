namespace JuniorProjectWTHR
{
    partial class ForecastUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labDT = new System.Windows.Forms.Label();
            this.labMainWeather = new System.Windows.Forms.Label();
            this.labWeatherDescripton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(2, 45);
            this.picWeatherIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(76, 71);
            this.picWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // labDT
            // 
            this.labDT.AutoSize = true;
            this.labDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labDT.Location = new System.Drawing.Point(11, 0);
            this.labDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(53, 14);
            this.labDT.TabIndex = 1;
            this.labDT.Text = "Sunday";
            // 
            // labMainWeather
            // 
            this.labMainWeather.AutoSize = true;
            this.labMainWeather.Location = new System.Drawing.Point(21, 127);
            this.labMainWeather.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMainWeather.Name = "labMainWeather";
            this.labMainWeather.Size = new System.Drawing.Size(31, 13);
            this.labMainWeather.TabIndex = 2;
            this.labMainWeather.Text = "Clear";
            this.labMainWeather.Click += new System.EventHandler(this.labMainWeather_Click);
            // 
            // labWeatherDescripton
            // 
            this.labWeatherDescripton.AutoSize = true;
            this.labWeatherDescripton.Location = new System.Drawing.Point(4, 151);
            this.labWeatherDescripton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labWeatherDescripton.Name = "labWeatherDescripton";
            this.labWeatherDescripton.Size = new System.Drawing.Size(60, 13);
            this.labWeatherDescripton.TabIndex = 3;
            this.labWeatherDescripton.Text = "Description";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labWeatherDescripton);
            this.Controls.Add(this.labMainWeather);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.picWeatherIcon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(80, 182);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labDT;
        public System.Windows.Forms.Label labMainWeather;
        public System.Windows.Forms.Label labWeatherDescripton;
    }
}
