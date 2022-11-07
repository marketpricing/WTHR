
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
            this.SuspendLayout();
            // 
            // btnBackKU
            // 
            this.btnBackKU.BackColor = System.Drawing.Color.Transparent;
            this.btnBackKU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBackKU.FlatAppearance.BorderSize = 0;
            this.btnBackKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackKU.ForeColor = System.Drawing.Color.White;
            this.btnBackKU.Location = new System.Drawing.Point(68, 383);
            this.btnBackKU.Name = "btnBackKU";
            this.btnBackKU.Size = new System.Drawing.Size(75, 23);
            this.btnBackKU.TabIndex = 0;
            this.btnBackKU.Text = "Back";
            this.btnBackKU.UseVisualStyleBackColor = false;
            // 
            // KualitasUdara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackKU);
            this.DoubleBuffered = true;
            this.Name = "KualitasUdara";
            this.Text = "KualitasUdara";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackKU;
    }
}