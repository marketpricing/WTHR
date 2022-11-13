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
    public partial class LupaPassword : Form
    {
        public LupaPassword()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=pgadminwthr.postgres.database.azure.com;Port=5432;Username=iwan;Password=Juniorproyek22!;Database=WTHR";
        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from user_resetpw(:_email, :_newPass)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_email", tbUsernameLupa.Text);
                cmd.Parameters.AddWithValue("_newPass", tbPasswordLupa.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    if (MessageBox.Show("Berhasil", "Password Successfully Changed. Go Login!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        conn.Close();
                        this.Hide();
                        Login lg = new Login();
                        lg.Show();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackLupaPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void LupaPassword_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
