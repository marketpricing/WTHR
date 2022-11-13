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
    public partial class Profile : Form
    {
        Homepage home;


        //public Profile()
        //{
         //   InitializeComponent();
        //}

        public Profile(Homepage hp)
        {
            InitializeComponent();
            this.home = hp;
        }
        private NpgsqlConnection conn;
        string connstring = "Host=pgadminwthr.postgres.database.azure.com;Port=5432;Username=iwan;Password=Juniorproyek22!;Database=WTHR";
        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;
        //private DataGridViewRow r;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            string username = home.lbUN.Text;
            lblProfileUser.Text = username;

            conn.Open();
            sql = @"select * from show_EmailProfile(:_username)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_username", username);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            
            lblProfileEmail.Text = dt.Rows[0]["_email"].ToString();
            conn.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
            
            


        }

        private void btnProfileBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage h = new Homepage();
            h.Show();
        }
    }
}
