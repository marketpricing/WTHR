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
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(1005, 14);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(47, 38);
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
            this.cbLokasi.Location = new System.Drawing.Point(63, 14);
            this.cbLokasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLokasi.Name = "cbLokasi";
            this.cbLokasi.Size = new System.Drawing.Size(427, 33);
            this.cbLokasi.TabIndex = 1;
            this.cbLokasi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnKualitasUdara
            // 
            this.btnKualitasUdara.BackColor = System.Drawing.Color.Transparent;
            this.btnKualitasUdara.FlatAppearance.BorderSize = 0;
            this.btnKualitasUdara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKualitasUdara.Location = new System.Drawing.Point(381, 92);
            this.btnKualitasUdara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKualitasUdara.Name = "btnKualitasUdara";
            this.btnKualitasUdara.Size = new System.Drawing.Size(73, 57);
            this.btnKualitasUdara.TabIndex = 2;
            this.btnKualitasUdara.UseVisualStyleBackColor = false;
            this.btnKualitasUdara.Click += new System.EventHandler(this.btnKualitasUdara_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnKualitasUdara);
            this.Controls.Add(this.cbLokasi);
            this.Controls.Add(this.btnProfile);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnKualitasUdara;
        public System.Windows.Forms.ComboBox cbLokasi;
    }
}