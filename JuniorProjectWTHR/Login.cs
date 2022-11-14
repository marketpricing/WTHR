using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuniorProjectWTHR
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=pgadminwthr.postgres.database.azure.com;Port=5432;Username=iwan;Password=Juniorproyek22!;Database=WTHR";
        private NpgsqlCommand cmd;
        private string sql = null;

        public static string uname;

        public static string nameprofile
        {
            get { return uname; }
            set { uname = value; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from user_login(:_username,:_password)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_username", tbUsername.Text);
                cmd.Parameters.AddWithValue("_password", tbPassword.Text);

                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if (result == 1)
                {
                    nameprofile = tbUsername.Text;
                    this.Hide();
                    Homepage h = new Homepage();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Please check your username or password", "login gagal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sometrhing went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnNoAkun_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void btnLupaPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            sendcode sc = new sendcode();
            sc.Show();

        }
    }
}
