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

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
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
    }
}
