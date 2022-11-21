
namespace JuniorProjectWTHR
{
    partial class KualitasUdara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KualitasUdara));
            this.btnBackKU = new System.Windows.Forms.Button();
            this.lbAqius = new System.Windows.Forms.Label();
            this.lbAqicn = new System.Windows.Forms.Label();
            this.lbMainus = new System.Windows.Forms.Label();
            this.lbMaincn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackKU
            // 
            this.btnBackKU.BackColor = System.Drawing.Color.Transparent;
            this.btnBackKU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBackKU.FlatAppearance.BorderSize = 0;
            this.btnBackKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackKU.ForeColor = System.Drawing.Color.White;
            this.btnBackKU.Location = new System.Drawing.Point(737, 379);
            this.btnBackKU.Name = "btnBackKU";
            this.btnBackKU.Size = new System.Drawing.Size(51, 48);
            this.btnBackKU.TabIndex = 0;
            this.btnBackKU.UseVisualStyleBackColor = false;
            this.btnBackKU.Click += new System.EventHandler(this.btnBackKU_Click);
            // 
            // lbAqius
            // 
            this.lbAqius.AutoSize = true;
            this.lbAqius.Location = new System.Drawing.Point(67, 76);
            this.lbAqius.Name = "lbAqius";
            this.lbAqius.Size = new System.Drawing.Size(32, 13);
            this.lbAqius.TabIndex = 1;
            this.lbAqius.Text = "aqius";
            // 
            // lbAqicn
            // 
            this.lbAqicn.AutoSize = true;
            this.lbAqicn.Location = new System.Drawing.Point(651, 99);
            this.lbAqicn.Name = "lbAqicn";
            this.lbAqicn.Size = new System.Drawing.Size(33, 13);
            this.lbAqicn.TabIndex = 2;
            this.lbAqicn.Text = "aqicn";
            // 
            // lbMainus
            // 
            this.lbMainus.AutoSize = true;
            this.lbMainus.Location = new System.Drawing.Point(654, 221);
            this.lbMainus.Name = "lbMainus";
            this.lbMainus.Size = new System.Drawing.Size(40, 13);
            this.lbMainus.TabIndex = 3;
            this.lbMainus.Text = "mainus";
            // 
            // lbMaincn
            // 
            this.lbMaincn.AutoSize = true;
            this.lbMaincn.Location = new System.Drawing.Point(657, 342);
            this.lbMaincn.Name = "lbMaincn";
            this.lbMaincn.Size = new System.Drawing.Size(41, 13);
            this.lbMaincn.TabIndex = 4;
            this.lbMaincn.Text = "maincn";
            // 
            // KualitasUdara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMaincn);
            this.Controls.Add(this.lbMainus);
            this.Controls.Add(this.lbAqicn);
            this.Controls.Add(this.lbAqius);
            this.Controls.Add(this.btnBackKU);
            this.DoubleBuffered = true;
            this.Name = "KualitasUdara";
            this.Text = "KualitasUdara";
            this.Load += new System.EventHandler(this.KualitasUdara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackKU;
        private System.Windows.Forms.Label lbAqius;
        private System.Windows.Forms.Label lbAqicn;
        private System.Windows.Forms.Label lbMainus;
        private System.Windows.Forms.Label lbMaincn;
    }
}