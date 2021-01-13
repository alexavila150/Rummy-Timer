using Rummy_Timer.Services;
using Rummy_Timer.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rummy_Timer
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AddPlayersPage();

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
