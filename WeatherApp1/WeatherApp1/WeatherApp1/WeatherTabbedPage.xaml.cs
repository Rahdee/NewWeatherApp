using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherTabbedPage : TabbedPage
    {
        public WeatherTabbedPage()
        {
            InitializeComponent();

        }
        private async void NavigationPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WeatherTabbedPage());

        }

    }
}