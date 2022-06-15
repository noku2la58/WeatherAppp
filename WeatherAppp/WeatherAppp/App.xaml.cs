using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherAppp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
       
            MainPage = new NavigationPage(new MainPage());
            {
                object BarTextColor = Color.PeachPuff;
                Color BarBackgroudColor = (Color)App.Current.Resources["Blue"];
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
