using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForcastApp
{
    public partial class WeatherForcastUI : Form
    {
        public WeatherForcastUI()
        {
            InitializeComponent();
        }

        private void WeatherForcastUI_Load(object sender, EventArgs e)
        {
            WeatherApiClient client = new WeatherApiClient();
            WeatherData weather = client.GetWeatherForcast("Dhaka", 3);

            foreach (List aList in weather.List)
            {
                string temperatures = aList.Temp.Morn + "\u00B0C   " + aList.Temp.Day + "\u00B0C   " + aList.Temp.Eve + "\u00B0C   " +
                                      aList.Temp.Night + "\u00B0C\n\n";
                temperatureLabel.Text += temperatures;
            }
        }
    }
}
