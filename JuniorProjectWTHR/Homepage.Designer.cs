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
            this.lbHumidity = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(1131, 17);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(52, 48);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // cbLokasi
            // 
            this.cbLokasi.BackColor = System.Drawing.Color.Black;
            this.cbLokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLokasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLokasi.ForeColor = System.Drawing.Color.White;
            this.cbLokasi.FormattingEnabled = true;
            this.cbLokasi.Location = new System.Drawing.Point(70, 17);
            this.cbLokasi.Name = "cbLokasi";
            this.cbLokasi.Size = new System.Drawing.Size(480, 37);
            this.cbLokasi.TabIndex = 1;
            this.cbLokasi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnKualitasUdara
            // 
            this.btnKualitasUdara.BackColor = System.Drawing.Color.Transparent;
            this.btnKualitasUdara.FlatAppearance.BorderSize = 0;
            this.btnKualitasUdara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKualitasUdara.Location = new System.Drawing.Point(429, 115);
            this.btnKualitasUdara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKualitasUdara.Name = "btnKualitasUdara";
            this.btnKualitasUdara.Size = new System.Drawing.Size(82, 71);
            this.btnKualitasUdara.TabIndex = 2;
            this.btnKualitasUdara.UseVisualStyleBackColor = false;
            this.btnKualitasUdara.Click += new System.EventHandler(this.btnKualitasUdara_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(439, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbLokasi
            // 
            this.lbLokasi.AutoSize = true;
            this.lbLokasi.Location = new System.Drawing.Point(496, 153);
            this.lbLokasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLokasi.Name = "lbLokasi";
            this.lbLokasi.Size = new System.Drawing.Size(55, 20);
            this.lbLokasi.TabIndex = 4;
            this.lbLokasi.Text = "Lokasi";
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Location = new System.Drawing.Point(33, 131);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(210, 166);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 5;
            this.pbIcon.TabStop = false;
            // 
            // lbKondisi
            // 
            this.lbKondisi.AutoSize = true;
            this.lbKondisi.BackColor = System.Drawing.Color.Transparent;
            this.lbKondisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKondisi.Location = new System.Drawing.Point(261, 130);
            this.lbKondisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKondisi.Name = "lbKondisi";
            this.lbKondisi.Size = new System.Drawing.Size(109, 32);
            this.lbKondisi.TabIndex = 6;
            this.lbKondisi.Text = "Kondisi";
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.BackColor = System.Drawing.Color.Transparent;
            this.lbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.Location = new System.Drawing.Point(261, 174);
            this.lbDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(102, 32);
            this.lbDetail.TabIndex = 7;
            this.lbDetail.Text = "Details";
            // 
            // lbSuhu
            // 
            this.lbSuhu.AutoSize = true;
            this.lbSuhu.BackColor = System.Drawing.Color.Transparent;
            this.lbSuhu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbSuhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuhu.Location = new System.Drawing.Point(0, 324);
            this.lbSuhu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSuhu.Name = "lbSuhu";
            this.lbSuhu.Size = new System.Drawing.Size(287, 113);
            this.lbSuhu.TabIndex = 8;
            this.lbSuhu.Text = "Suhu";
            // 
            // lbWind
            // 
            this.lbWind.AutoSize = true;
            this.lbWind.BackColor = System.Drawing.Color.Transparent;
            this.lbWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWind.Location = new System.Drawing.Point(261, 220);
            this.lbWind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWind.Name = "lbWind";
            this.lbWind.Size = new System.Drawing.Size(162, 32);
            this.lbWind.TabIndex = 9;
            this.lbWind.Text = "WindSpeed";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidity.Location = new System.Drawing.Point(261, 265);
            this.lbHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(125, 32);
            this.lbHumidity.TabIndex = 10;
            this.lbHumidity.Text = "Humidity";
            // 
            // FLP
            // 
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(623, 265);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(581, 341);
            this.FLP.TabIndex = 11;
            this.FLP.Paint += new System.Windows.Forms.PaintEventHandler(this.FLP_Paint);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.lbHumidity);
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
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.FlowLayoutPanel FLP;
    }
}