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
                    label1.Text = "GOOD";
                }
                else if (AQIus > 50 && AQIus <=100)
                {
                    pictureBox1.BackColor = Color.FromArgb(210, 210, 96);
                    label1.Text = "MODERATE";
                }
                else if (AQIus > 100 && AQIus <= 150)
                {
                    pictureBox1.BackColor = Color.FromArgb(252, 153, 86);
                    label1.Text = "UNHEALTHY FOR SENSITIVE GROUPS";
                }
                else if (AQIus > 150 && AQIus <= 200)
                {
                    pictureBox1.BackColor = Color.FromArgb(247, 129, 98);
                    label1.Text = "UNHEALTHY";
                }
                else if (AQIus > 200 && AQIus <= 300)
                {
                    pictureBox1.BackColor = Color.FromArgb(162, 121, 157);
                    label1.Text = "VERY UNHEALTHY";
                }
                else
                {
                    pictureBox1.BackColor = Color.FromArgb(160, 120, 100);
                    label1.Text = "HAZARDOUS";
                }

            }
        }

    }
}
