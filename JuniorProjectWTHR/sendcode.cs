using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuniorProjectWTHR
{
    public partial class sendcode : Form
    {
        string randomcode;
        public static string to;

        public sendcode()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (tbSendEmail.Text).ToString();
            from = "proyekwthr@gmail.com";
            pass = "scjhzyhhldlnaijq";
            messagebody = $"Your reset code is {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Password Reset Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Successfully Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(randomcode == (tbCode.Text).ToString())
            {
                to = tbSendEmail.Text;
                LupaPassword lupa = new LupaPassword();
                this.Hide();
                lupa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code!!!");
            }
        }

        private void sendcode_Load(object sender, EventArgs e)
        {

        }
    }
}
