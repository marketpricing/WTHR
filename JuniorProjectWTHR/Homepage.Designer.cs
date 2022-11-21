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
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lbKondisi = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.lbSuhu = new System.Windows.Forms.Label();
            this.lbWind = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
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
            this.cbLokasi.ForeColor = System.Drawing.Color.White;
            this.cbLokasi.FormattingEnabled = true;
            this.cbLokasi.Location = new System.Drawing.Point(47, 11);
            this.cbLokasi.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnKualitasUdara.Text = "Hai";
            this.btnKualitasUdara.UseVisualStyleBackColor = false;
            this.btnKualitasUdara.Click += new System.EventHandler(this.btnKualitasUdara_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(293, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Location = new System.Drawing.Point(-22, 55);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(236, 162);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 5;
            this.pbIcon.TabStop = false;
            // 
            // lbKondisi
            // 
            this.lbKondisi.AutoSize = true;
            this.lbKondisi.BackColor = System.Drawing.Color.Transparent;
            this.lbKondisi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKondisi.Location = new System.Drawing.Point(150, 398);
            this.lbKondisi.Name = "lbKondisi";
            this.lbKondisi.Size = new System.Drawing.Size(42, 23);
            this.lbKondisi.TabIndex = 6;
            this.lbKondisi.Text = "rain";
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.BackColor = System.Drawing.Color.Transparent;
            this.lbDetail.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbDetail.Location = new System.Drawing.Point(31, 269);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(112, 29);
            this.lbDetail.TabIndex = 7;
            this.lbDetail.Text = "Light rain";
            // 
            // lbSuhu
            // 
            this.lbSuhu.AutoSize = true;
            this.lbSuhu.BackColor = System.Drawing.Color.Transparent;
            this.lbSuhu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbSuhu.Font = new System.Drawing.Font("Tahoma", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.lbSuhu.Location = new System.Drawing.Point(12, 188);
            this.lbSuhu.Name = "lbSuhu";
            this.lbSuhu.Size = new System.Drawing.Size(250, 81);
            this.lbSuhu.TabIndex = 8;
            this.lbSuhu.Text = "22.3 C";
            this.lbSuhu.Click += new System.EventHandler(this.lbSuhu_Click);
            // 
            // lbWind
            // 
            this.lbWind.AutoSize = true;
            this.lbWind.BackColor = System.Drawing.Color.Transparent;
            this.lbWind.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWind.Location = new System.Drawing.Point(282, 398);
            this.lbWind.Name = "lbWind";
            this.lbWind.Size = new System.Drawing.Size(46, 23);
            this.lbWind.TabIndex = 9;
            this.lbWind.Text = "44,2";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lbHumidity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidity.Location = new System.Drawing.Point(43, 398);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(30, 23);
            this.lbHumidity.TabIndex = 10;
            this.lbHumidity.Text = "21";
            // 
            // FLP
            // 
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(413, 168);
            this.FLP.Margin = new System.Windows.Forms.Padding(2);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(348, 207);
            this.FLP.TabIndex = 11;
            this.FLP.Paint += new System.Windows.Forms.PaintEventHandler(this.FLP_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Humidity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Windspeed";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(120, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 95);
            this.label4.TabIndex = 15;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(241, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 95);
            this.label5.TabIndex = 16;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSuhu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHumidity);
            this.Controls.Add(this.lbWind);
            this.Controls.Add(this.lbDetail);
            this.Controls.Add(this.lbKondisi);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnKualitasUdara);
            this.Controls.Add(this.cbLokasi);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.FLP);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lbKondisi;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Label lbSuhu;
        private System.Windows.Forms.Label lbWind;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}