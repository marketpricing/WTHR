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
    public partial class Homepage : Form
    {
        Login log;
        public Homepage()
        {
            InitializeComponent();
        }

        public Homepage(Login lgn)
        {
            InitializeComponent();
            this.log = lgn;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKualitasUdara_Click(object sender, EventArgs e)
        {
            this.Hide();
            KualitasUdara ku = new KualitasUdara();
            ku.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile(this);
            p.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            lbUN.Text = log.tbUsername.Text;
        }
    }
}
