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
        public Homepage()
        {
            InitializeComponent();

           
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
            Profile p = new Profile();
            p.Show();
        }
    }
}
