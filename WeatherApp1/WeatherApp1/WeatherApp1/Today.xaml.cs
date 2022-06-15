using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowPage : ContentPage
    {
        public NowPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
           base.OnAppearing();
           await WeathersData();
        }
        public class Weather
        {
            public string Temp { get; set; }
            public string Date { get; set; }
            public string Icon { get; set; }
        }

        public List<Weather> Weathers { get => GetWeatherData(); }

        private List<Weather> GetWeatherData()
        {
            var tempList = new List<Weather>();
            tempList.Add(new Weather { Temp = "22", Date = "Sunday 16", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "21", Date = "Monday 17", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "20", Date = "Tuesday 18", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "12", Date = "Wednesday 19", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "17", Date = "Thursday 20", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "20", Date = "Friday 21", Icon = "weather.png" });

            return tempList;
        }



        private async Task WeathersData()
        {
            var data = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            if (data != PermissionStatus.Granted)
            {
                var newData = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }
            var location = await Geolocation.GetLocationAsync();
            var latitude = location.Latitude;
            var longitude = location.Longitude;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            string url = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&units=metric&appid=3df9a4928aca7d49f2dedde30969157d";
            var response = await client.GetStringAsync(url);
            var weathersData = JsonConvert.DeserializeObject<Root>(response);
            BindingContext = weathersData;
        }
    }
}