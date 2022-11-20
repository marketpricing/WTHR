using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

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

        private void Homepage_Load(object sender, EventArgs e)
        {
            
        }

        string APIkeys = "cf2175167bd77ad7edf92547da1081b1";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", cbLokasi.Text, APIkeys);
                var json = web.DownloadString(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pbIcon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                lbKondisi.Text = info.weather[0].main;
                lbDetail.Text = info.weather[0].description;

                lbWind.Text = info.wind.speed.ToString();

                lbPressure.Text = info.main.pressure.ToString();
                lbSuhu.Text = info.main.temp.ToString();

            }
        }
    }
}
