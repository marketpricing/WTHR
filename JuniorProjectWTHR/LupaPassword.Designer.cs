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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsernameLupa
            // 
            this.tbUsernameLupa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsernameLupa.Location = new System.Drawing.Point(395, 193);
            this.tbUsernameLupa.Name = "tbUsernameLupa";
            this.tbUsernameLupa.Size = new System.Drawing.Size(408, 19);
            this.tbUsernameLupa.TabIndex = 0;
            // 
            // tbPasswordLupa
            // 
            this.tbPasswordLupa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordLupa.Location = new System.Drawing.Point(396, 286);
            this.tbPasswordLupa.Name = "tbPasswordLupa";
            this.tbPasswordLupa.Size = new System.Drawing.Size(408, 19);
            this.tbPasswordLupa.TabIndex = 1;
            // 
            // tbConfimPassLupa
            // 
            this.tbConfimPassLupa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfimPassLupa.Location = new System.Drawing.Point(396, 379);
            this.tbConfimPassLupa.Name = "tbConfimPassLupa";
            this.tbConfimPassLupa.Size = new System.Drawing.Size(408, 19);
            this.tbConfimPassLupa.TabIndex = 2;
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnNewPassword.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.Location = new System.Drawing.Point(489, 486);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(227, 48);
            this.btnNewPassword.TabIndex = 3;
            this.btnNewPassword.Text = "Buat Paassword Baru";
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // LupaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.tbConfimPassLupa);
            this.Controls.Add(this.tbPasswordLupa);
            this.Controls.Add(this.tbUsernameLupa);
            this.DoubleBuffered = true;
            this.Name = "LupaPassword";
            this.Text = "LupaPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsernameLupa;
        private System.Windows.Forms.TextBox tbPasswordLupa;
        private System.Windows.Forms.TextBox tbConfimPassLupa;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}