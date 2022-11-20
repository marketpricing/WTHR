namespace JuniorProjectWTHR
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.btnProfile = new System.Windows.Forms.Button();
            this.cbLokasi = new System.Windows.Forms.ComboBox();
            this.btnKualitasUdara = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbLokasi = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lbKondisi = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.lbSuhu = new System.Windows.Forms.Label();
            this.lbWind = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(754, 11);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(35, 31);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // cbLokasi
            // 
            this.cbLokasi.BackColor = System.Drawing.Color.Black;
            this.cbLokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLokasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLokasi.FormattingEnabled = true;
            this.cbLokasi.Location = new System.Drawing.Point(47, 11);
            this.cbLokasi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLokasi.Name = "cbLokasi";
            this.cbLokasi.Size = new System.Drawing.Size(321, 28);
            this.cbLokasi.TabIndex = 1;
            this.cbLokasi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnKualitasUdara
            // 
            this.btnKualitasUdara.BackColor = System.Drawing.Color.Transparent;
            this.btnKualitasUdara.FlatAppearance.BorderSize = 0;
            this.btnKualitasUdara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKualitasUdara.Location = new System.Drawing.Point(286, 75);
            this.btnKualitasUdara.Name = "btnKualitasUdara";
            this.btnKualitasUdara.Size = new System.Drawing.Size(55, 46);
            this.btnKualitasUdara.TabIndex = 2;
            this.btnKualitasUdara.UseVisualStyleBackColor = false;
            this.btnKualitasUdara.Click += new System.EventHandler(this.btnKualitasUdara_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbLokasi
            // 
            this.lbLokasi.AutoSize = true;
            this.lbLokasi.Location = new System.Drawing.Point(307, 75);
            this.lbLokasi.Name = "lbLokasi";
            this.lbLokasi.Size = new System.Drawing.Size(38, 13);
            this.lbLokasi.TabIndex = 4;
            this.lbLokasi.Text = "Lokasi";
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(22, 85);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(140, 108);
            this.pbIcon.TabIndex = 5;
            this.pbIcon.TabStop = false;
            // 
            // lbKondisi
            // 
            this.lbKondisi.AutoSize = true;
            this.lbKondisi.Location = new System.Drawing.Point(179, 107);
            this.lbKondisi.Name = "lbKondisi";
            this.lbKondisi.Size = new System.Drawing.Size(41, 13);
            this.lbKondisi.TabIndex = 6;
            this.lbKondisi.Text = "Kondisi";
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Location = new System.Drawing.Point(179, 140);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(39, 13);
            this.lbDetail.TabIndex = 7;
            this.lbDetail.Text = "Details";
            // 
            // lbSuhu
            // 
            this.lbSuhu.AutoSize = true;
            this.lbSuhu.Location = new System.Drawing.Point(83, 251);
            this.lbSuhu.Name = "lbSuhu";
            this.lbSuhu.Size = new System.Drawing.Size(32, 13);
            this.lbSuhu.TabIndex = 8;
            this.lbSuhu.Text = "Suhu";
            // 
            // lbWind
            // 
            this.lbWind.AutoSize = true;
            this.lbWind.Location = new System.Drawing.Point(235, 220);
            this.lbWind.Name = "lbWind";
            this.lbWind.Size = new System.Drawing.Size(63, 13);
            this.lbWind.TabIndex = 9;
            this.lbWind.Text = "WindSpeed";
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.Location = new System.Drawing.Point(235, 261);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(48, 13);
            this.lbPressure.TabIndex = 10;
            this.lbPressure.Text = "Pressure";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.lbWind);
            this.Controls.Add(this.lbSuhu);
            this.Controls.Add(this.lbDetail);
            this.Controls.Add(this.lbKondisi);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lbLokasi);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnKualitasUdara);
            this.Controls.Add(this.cbLokasi);
            this.Controls.Add(this.btnProfile);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnKualitasUdara;
        public System.Windows.Forms.ComboBox cbLokasi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbLokasi;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lbKondisi;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Label lbSuhu;
        private System.Windows.Forms.Label lbWind;
        private System.Windows.Forms.Label lbPressure;
    }
}