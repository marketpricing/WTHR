
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
            this.btn_Back.Location = new System.Drawing.Point(383, 500);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(53, 57);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tbSendEmail
            // 
            this.tbSendEmail.BackColor = System.Drawing.Color.Black;
            this.tbSendEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSendEmail.ForeColor = System.Drawing.Color.White;
            this.tbSendEmail.Location = new System.Drawing.Point(74, 165);
            this.tbSendEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSendEmail.Name = "tbSendEmail";
            this.tbSendEmail.Size = new System.Drawing.Size(310, 28);
            this.tbSendEmail.TabIndex = 2;
            this.tbSendEmail.TextChanged += new System.EventHandler(this.tbSendEmail_TextChanged);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnSendEmail.FlatAppearance.BorderSize = 0;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Location = new System.Drawing.Point(103, 381);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(253, 37);
            this.btnSendEmail.TabIndex = 3;
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Transparent;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Location = new System.Drawing.Point(104, 439);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(248, 38);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.Black;
            this.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.ForeColor = System.Drawing.Color.White;
            this.tbCode.Location = new System.Drawing.Point(72, 277);
            this.tbCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(312, 28);
            this.tbCode.TabIndex = 7;
            // 
            // sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 571);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.tbSendEmail);
            this.Controls.Add(this.btn_Back);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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