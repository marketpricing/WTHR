
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.lblSendEmail = new System.Windows.Forms.Label();
            this.tbSendEmail = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(39, 28);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lblSendEmail
            // 
            this.lblSendEmail.AutoSize = true;
            this.lblSendEmail.Location = new System.Drawing.Point(137, 75);
            this.lblSendEmail.Name = "lblSendEmail";
            this.lblSendEmail.Size = new System.Drawing.Size(32, 13);
            this.lblSendEmail.TabIndex = 1;
            this.lblSendEmail.Text = "Email";
            // 
            // tbSendEmail
            // 
            this.tbSendEmail.Location = new System.Drawing.Point(197, 72);
            this.tbSendEmail.Name = "tbSendEmail";
            this.tbSendEmail.Size = new System.Drawing.Size(100, 20);
            this.tbSendEmail.TabIndex = 2;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(197, 109);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSendEmail.TabIndex = 3;
            this.btnSendEmail.Text = "Send Code";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(140, 156);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(197, 156);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 20);
            this.tbCode.TabIndex = 5;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(197, 193);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.tbSendEmail);
            this.Controls.Add(this.lblSendEmail);
            this.Controls.Add(this.btn_Back);
            this.Name = "sendcode";
            this.Text = "sendcode";
            this.Load += new System.EventHandler(this.sendcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lblSendEmail;
        private System.Windows.Forms.TextBox tbSendEmail;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnVerify;
    }
}