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
            this.btnProfile.Location = new System.Drawing.Point(1095, 22);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 77);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // cbLokasi
            // 
            this.cbLokasi.FormattingEnabled = true;
            this.cbLokasi.Location = new System.Drawing.Point(68, 43);
            this.cbLokasi.Name = "cbLokasi";
            this.cbLokasi.Size = new System.Drawing.Size(348, 28);
            this.cbLokasi.TabIndex = 1;
            this.cbLokasi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnKualitasUdara
            // 
            this.btnKualitasUdara.BackColor = System.Drawing.Color.Transparent;
            this.btnKualitasUdara.FlatAppearance.BorderSize = 0;
            this.btnKualitasUdara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKualitasUdara.Location = new System.Drawing.Point(618, 117);
            this.btnKualitasUdara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKualitasUdara.Name = "btnKualitasUdara";
            this.btnKualitasUdara.Size = new System.Drawing.Size(82, 71);
            this.btnKualitasUdara.TabIndex = 2;
            this.btnKualitasUdara.UseVisualStyleBackColor = false;
            this.btnKualitasUdara.Click += new System.EventHandler(this.btnKualitasUdara_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnKualitasUdara);
            this.Controls.Add(this.cbLokasi);
            this.Controls.Add(this.btnProfile);
            this.DoubleBuffered = true;
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.ComboBox cbLokasi;
        private System.Windows.Forms.Button btnKualitasUdara;
    }
}