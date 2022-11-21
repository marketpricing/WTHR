using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuniorProjectWTHR
{
    public partial class KualitasUdara : Form
    {
        double longitude;
        double latitude;
        Homepage home;

        public KualitasUdara(Homepage hp)
        {
            InitializeComponent();
            this.home = hp;
        }

        private void btnBackKU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage h = new Homepage();
            h.Show();
        }

        private void KualitasUdara_Load(object sender, EventArgs e)
        {
            longitude = home.lon;
            latitude = home.lat;
            getAirInfo();
        }

        string APIkeysAir = "26214821-e2d3-4346-b6da-e760b4a2c8cc";
        void getAirInfo()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.airvisual.com/v2/nearest_city?lat={0}&lon={1}&key={2}", latitude, longitude, APIkeysAir);
                var json = web.DownloadString(url);
                AirInfo.root airInfo = JsonConvert.DeserializeObject<AirInfo.root>(json);

                lbAqius.Text = (airInfo.data.current.pollution.aqius).ToString();
                lbAqicn.Text = (airInfo.data.current.pollution.aqicn).ToString();
                lbMainus.Text = (airInfo.data.current.pollution.mainus).ToString();
                lbMaincn.Text = (airInfo.data.current.pollution.maincn).ToString();

                int AQIus = airInfo.data.current.pollution.aqius;

                if(AQIus >= 0 && AQIus <= 50)
                {
                    pictureBox1.BackColor = Color.FromArgb(148, 194, 103);
                    lbAqius.BackColor = Color.FromArgb(148, 194, 103);
                    label1.BackColor = Color.FromArgb(148, 194, 103);
                    pictureBox2.ImageLocation = "https://i.postimg.cc/FH9GYqG4/1.png";
                    label1.Text = "GOOD";
                }
                else if (AQIus > 50 && AQIus <=100)
                {
                    pictureBox1.BackColor = Color.FromArgb(247, 212, 96);
                    lbAqius.BackColor = Color.FromArgb(247, 212, 96);
                    label1.BackColor = Color.FromArgb(247, 212, 96);
                    pictureBox2.ImageLocation = "https://i.postimg.cc/FzygRgLz/2.png";
                    label1.Text = "MODERATE";
                }
                else if (AQIus > 100 && AQIus <= 150)
                {
                    pictureBox1.BackColor = Color.FromArgb(252, 153, 86);
                    lbAqius.BackColor = Color.FromArgb(252, 153, 86);
                    label1.BackColor = Color.FromArgb(252, 153, 86);
                    pictureBox2.ImageLocation = "https://i.postimg.cc/qq46mfNB/3.png";
                    label1.Text = "UNHEALTHY FOR SENSITIVE GROUPS";
                }
                else if (AQIus > 150 && AQIus <= 200)
                {
                    pictureBox1.BackColor = Color.FromArgb(247, 129, 98);
                    lbAqius.BackColor = Color.FromArgb(247, 129, 98);
                    label1.BackColor = Color.FromArgb(247, 129, 98);
                    pictureBox2.ImageLocation = "https://i.postimg.cc/gkMLKTmd/4.png";
                    label1.Text = "UNHEALTHY";
                }
                else if (AQIus > 200 && AQIus <= 300)
                {
                    pictureBox1.BackColor = Color.FromArgb(162, 121, 157);
                    lbAqius.BackColor = Color.FromArgb(162, 121, 157);
                    label1.BackColor = Color.FromArgb(162, 121, 157);
                    pictureBox2.ImageLocation = "https://i.postimg.cc/sXy2zYsw/5.png";
                    label1.Text = "VERY UNHEALTHY";
                }
                else
                {
                    pictureBox1.BackColor = Color.FromArgb(160, 120, 100);
                    lbAqius.BackColor = Color.FromArgb(160, 120, 100);
                    label1.BackColor = Color.FromArgb(160, 120, 100);
                    pictureBox2.ImageLocation = "https://i.postimg.cc/j5ZRrB8S/6.png";
                    label1.Text = "HAZARDOUS";
                }

            }
        }

        private void lbAqius_Click(object sender, EventArgs e)
        {

        }

        private void lbMainus_Click(object sender, EventArgs e)
        {

        }

        private void lbMaincn_Click(object sender, EventArgs e)
        {

        }

        private void lbAqicn_Click(object sender, EventArgs e)
        {

        }
    }
}
