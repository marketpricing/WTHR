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
using static System.Net.WebRequestMethods;

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
            cbLokasi.Text = "Yogyakarta";
            getWeather();
            getForecast();
            getAirInfo();
        }

        string APIkeys = "18dede3a5891aa7f0c4f991203e451c0";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }

        double lon;
        double lat;
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

                lbHumidity.Text = info.main.humidity.ToString();
                lbSuhu.Text = convertTemp(info.main.temp).ToString() + "°C";

                lon = info.coord.lon;
                lat = info.coord.lat;

            }
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }
        double convertTemp(double K)
        {
            double celcius = Math.Round(K - 273, 1);

            return celcius; 
        }

        
        void getForecast()
        {
            FLP.Controls.Clear();
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}", lat, lon, APIkeys);
                var json = web.DownloadString(url);
                WeatherForecast.forecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.forecastInfo>(json);

                ForecastUC FUC;
                for (int i = 0; i<4; i++)
                {
                    FUC = new ForecastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labMainWeather.Text = ForecastInfo.daily[i].weather[0].main;
                    FUC.labWeatherDescripton.Text = ForecastInfo.daily[i].weather[0].description;
                    FUC.labDT.Text = convertDateTime(ForecastInfo.daily[i].dt).DayOfWeek.ToString();

                    FLP.Controls.Add(FUC);
                }
                

            }
        }

        string APIkeysAir = "26214821-e2d3-4346-b6da-e760b4a2c8cc";
        void getAirInfo()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.airvisual.com/v2/nearest_city?lat={0}&lon={1}&key={2}", lat, lon, APIkeysAir);
                var json = web.DownloadString(url);
                AirInfo.root airInfo = JsonConvert.DeserializeObject<AirInfo.root>(json);

                btnKualitasUdara.Text = (airInfo.data.current.pollution.aqius).ToString();

            }
        }

        private void FLP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSuhu_Click(object sender, EventArgs e)
        {

        }

        private void lbLokasi_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
