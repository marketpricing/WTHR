
namespace JuniorProjectWTHR
{
    partial class sendcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendcode));
            this.btn_Back = new System.Windows.Forms.Button();
            this.tbSendEmail = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(251, 325);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(45, 37);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tbSendEmail
            // 
            this.tbSendEmail.BackColor = System.Drawing.Color.Black;
            this.tbSendEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSendEmail.ForeColor = System.Drawing.Color.White;
            this.tbSendEmail.Location = new System.Drawing.Point(49, 107);
            this.tbSendEmail.Name = "tbSendEmail";
            this.tbSendEmail.Size = new System.Drawing.Size(207, 17);
            this.tbSendEmail.TabIndex = 2;
            this.tbSendEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSendEmail.TextChanged += new System.EventHandler(this.tbSendEmail_TextChanged);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.btnSendEmail.FlatAppearance.BorderSize = 0;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Location = new System.Drawing.Point(68, 248);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(169, 25);
            this.btnSendEmail.TabIndex = 3;
            this.btnSendEmail.Text = "SEND CODE";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(69, 285);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(165, 25);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.Black;
            this.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.ForeColor = System.Drawing.Color.White;
            this.tbCode.Location = new System.Drawing.Point(48, 180);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(208, 19);
            this.tbCode.TabIndex = 7;
            this.tbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(305, 371);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.tbSendEmail);
            this.Controls.Add(this.btn_Back);
            this.DoubleBuffered = true;
            this.Name = "sendcode";
            this.Text = "sendcode";
            this.Load += new System.EventHandler(this.sendcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tbSendEmail;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox tbCode;
    }
}