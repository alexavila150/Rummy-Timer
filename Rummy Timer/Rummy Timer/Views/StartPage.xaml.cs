using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rummy_Timer.Logic;
using Rummy_Timer.Models;

namespace Rummy_Timer.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        private readonly ILogic logic = Logic.Logic.GetInstance();
        public StartPage()
        {
            Console.WriteLine("StartPage created"); 
            InitializeComponent();
            logic.Timer.OneSecondPassed += OnOneSecondPassed;
            logic.Timer.Finished += OnFinished;
        }

        public void OnButtonClicked(object value, EventArgs eventArgs) {
            logic.GoToNextTurn();
            Device.BeginInvokeOnMainThread(
                () => timerButton.Text = "30"
            );
        }

        public void OnOneSecondPassed(object value, TimerEventArgs timerEventArgs) {
            Device.BeginInvokeOnMainThread(
                () => timerButton.Text = timerEventArgs.TimeLeft.ToString()
            ); 
        }

        public void OnFinished(object value, TimerEventArgs timerEventArgs)
        {
            Device.BeginInvokeOnMainThread(
                () => timerButton.BackgroundColor = Color.Red
            );
        }
    }
}