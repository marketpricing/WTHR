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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=maholtra26;Database=WTHR";
        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbPw.Text == tbConfirm.Text)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from user_insert(:_username,:_password,:_email)";
                    cmd = new NpgsqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("_username", tbUn.Text);
                    cmd.Parameters.AddWithValue("_password", tbPw.Text);
                    cmd.Parameters.AddWithValue("_email", tbEmail.Text);

                    int result = (int)cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        MessageBox.Show("Silahkan Login", "Akun Telah Dibuat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Sometrhing went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Periksa kembali password", "Password Berbeda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
