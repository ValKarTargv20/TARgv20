using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARgv20
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); //dlja xml

            MainPage = new MainPage(); //zamena nachalnoj stranicy
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
