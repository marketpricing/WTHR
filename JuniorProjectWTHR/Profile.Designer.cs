namespace JuniorProjectWTHR
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfileUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProfileBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileEmail.Location = new System.Drawing.Point(422, 163);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(0, 20);
            this.lblProfileEmail.TabIndex = 0;
            this.lblProfileEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProfileUser
            // 
            this.lblProfileUser.AutoSize = true;
            this.lblProfileUser.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileUser.Location = new System.Drawing.Point(422, 221);
            this.lblProfileUser.Name = "lblProfileUser";
            this.lblProfileUser.Size = new System.Drawing.Size(0, 20);
            this.lblProfileUser.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(352, 305);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(156, 73);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfileBack
            // 
            this.btnProfileBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(151)))), ((int)(((byte)(184)))));
            this.btnProfileBack.FlatAppearance.BorderSize = 0;
            this.btnProfileBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileBack.ForeColor = System.Drawing.Color.White;
            this.btnProfileBack.Location = new System.Drawing.Point(32, 418);
            this.btnProfileBack.Name = "btnProfileBack";
            this.btnProfileBack.Size = new System.Drawing.Size(80, 40);
            this.btnProfileBack.TabIndex = 3;
            this.btnProfileBack.Text = "Back";
            this.btnProfileBack.UseVisualStyleBackColor = false;
            this.btnProfileBack.Click += new System.EventHandler(this.btnProfileBack_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(848, 478);
            this.Controls.Add(this.btnProfileBack);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblProfileUser);
            this.Controls.Add(this.lblProfileEmail);
            this.DoubleBuffered = true;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfileUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProfileBack;
    }
}