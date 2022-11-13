namespace JuniorProjectWTHR
{
    partial class LupaPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LupaPassword));
            this.tbUsernameLupa = new System.Windows.Forms.TextBox();
            this.tbPasswordLupa = new System.Windows.Forms.TextBox();
            this.tbConfimPassLupa = new System.Windows.Forms.TextBox();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.btnBackLupaPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsernameLupa
            // 
            this.tbUsernameLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.tbUsernameLupa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsernameLupa.Location = new System.Drawing.Point(234, 222);
            this.tbUsernameLupa.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsernameLupa.Name = "tbUsernameLupa";
            this.tbUsernameLupa.Size = new System.Drawing.Size(301, 13);
            this.tbUsernameLupa.TabIndex = 0;
            // 
            // tbPasswordLupa
            // 
            this.tbPasswordLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.tbPasswordLupa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordLupa.Location = new System.Drawing.Point(234, 276);
            this.tbPasswordLupa.Margin = new System.Windows.Forms.Padding(2);
            this.tbPasswordLupa.Name = "tbPasswordLupa";
            this.tbPasswordLupa.Size = new System.Drawing.Size(301, 13);
            this.tbPasswordLupa.TabIndex = 1;
            // 
            // tbConfimPassLupa
            // 
            this.tbConfimPassLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.tbConfimPassLupa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfimPassLupa.Location = new System.Drawing.Point(234, 332);
            this.tbConfimPassLupa.Margin = new System.Windows.Forms.Padding(2);
            this.tbConfimPassLupa.Name = "tbConfimPassLupa";
            this.tbConfimPassLupa.Size = new System.Drawing.Size(302, 13);
            this.tbConfimPassLupa.TabIndex = 2;
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPassword.FlatAppearance.BorderSize = 0;
            this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPassword.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.Location = new System.Drawing.Point(399, 370);
            this.btnNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(148, 31);
            this.btnNewPassword.TabIndex = 3;
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // btnBackLupaPassword
            // 
            this.btnBackLupaPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnBackLupaPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBackLupaPassword.FlatAppearance.BorderSize = 0;
            this.btnBackLupaPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackLupaPassword.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLupaPassword.ForeColor = System.Drawing.Color.White;
            this.btnBackLupaPassword.Location = new System.Drawing.Point(732, 387);
            this.btnBackLupaPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackLupaPassword.Name = "btnBackLupaPassword";
            this.btnBackLupaPassword.Size = new System.Drawing.Size(46, 38);
            this.btnBackLupaPassword.TabIndex = 7;
            this.btnBackLupaPassword.UseVisualStyleBackColor = false;
            this.btnBackLupaPassword.Click += new System.EventHandler(this.btnBackLupaPassword_Click);
            // 
            // LupaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackLupaPassword);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.tbConfimPassLupa);
            this.Controls.Add(this.tbPasswordLupa);
            this.Controls.Add(this.tbUsernameLupa);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LupaPassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "LupaPassword";
            this.Load += new System.EventHandler(this.LupaPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsernameLupa;
        private System.Windows.Forms.TextBox tbPasswordLupa;
        private System.Windows.Forms.TextBox tbConfimPassLupa;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Button btnBackLupaPassword;
    }
}