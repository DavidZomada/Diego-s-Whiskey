using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Diego_s_Whiskey.Services;
using Diego_s_Whiskey.Views;

namespace Diego_s_Whiskey
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
