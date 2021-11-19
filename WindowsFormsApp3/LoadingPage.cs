using Newtonsoft.Json;
using System;
using System.Device.Location;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class LoadingPage : Form
    {
        /// <summary>
        /// This page was created as a buffer to give the weather data time to be loaded correctly before the main form runs.
        /// Before I had this page, the main form would run and there would be a delay between when the form appeared and
        /// when the weather data appeared, which I felt looked unprofessional. Now the main form will not be run or appear until
        /// a long enough time has elapsed for the weather data to be obtained via the API or a failure to be noted and displayed 
        /// when then main form runs.
        /// </summary>

        public LoadingPage()
        {
            InitializeComponent();
            LocationService();
            LayoutSetup();
        }

        // Variables
        bool weatherComplete;
        double longitude;
        double latitude;
        public static string weatherCondition;
        public static string temperature;
        public static string weatherImage;

        // The coordinate watcher
        private GeoCoordinateWatcher Watcher = null;

        // Create and start the watcher
        private void LocationService()
        {
            // Create the watcher
            Watcher = new GeoCoordinateWatcher();

            // Catch the StatusChanged event
            Watcher.StatusChanged += Watcher_StatusChanged;

            // Start the watcher
            Watcher.Start();
        }

        // StatusChanged event
        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                // If location is unknown then note failure and progress, else use location to get weather data and progress
                if (Watcher.Position.Location.IsUnknown)
                {
                    weatherComplete = false;
                }
                else
                {
                    GeoCoordinate location = Watcher.Position.Location;
                    longitude = location.Longitude;
                    latitude = location.Latitude;

                    // Call method to get and store weather information
                    getWeather();
                }
            }
        }

        // Method to get weather data
        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                // OpenWeatherAPI address call
                string url = string.Format($"http://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid=656af6b0f09d279ae535a0eab41601cf&units=imperial");

                // Call OpenWeatherAPI
                var json = web.DownloadString(url);

                // Convert return
                var result = JsonConvert.DeserializeObject<WeatherInfo.Rootobject>(json);

                // Store result as WeatherInfo object
                WeatherInfo.Rootobject output = result;

                // Get raw description
                string desc = output.weather[0].description.ToString();

                // Convert description to correct format
                desc.ToCharArray();
                char[] descChar = desc.ToCharArray();
                for (int i = 0; i < descChar.Length; i++)
                {
                    if (i == 0)
                    {
                        descChar[i] = char.ToUpper(descChar[i]);
                    }
                    else if (descChar[i] == ' ')
                    {
                        descChar[i + 1] = char.ToUpper(descChar[i + 1]);
                    }
                }

                // Save weather information and completion tracker
                weatherImage = output.weather[0].icon.ToString();
                temperature = string.Format("{0:0}\u00B0" + "F", output.main.temp);
                weatherCondition = desc = new string(descChar);
                weatherComplete = true;
            }
        }

        // Format Design Of Page
        public void LayoutSetup()
        {
            // Align controls horizontally
            circularProgressBar1.Left = (int)(this.Width * 0.5f - circularProgressBar1.Width * 0.5f);
            circularProgressBar1.Value = 10;
        }

        // Timer to animate progress bar and call main form
        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Minimum += 1;
            circularProgressBar1.Maximum += 1;

            if (circularProgressBar1.Value >= 150)
            {
                timer1.Stop();
                this.Hide();
                Main newMain = new Main(weatherComplete);
                newMain.ShowDialog();
                this.Close();
            }
        }
    }
}
