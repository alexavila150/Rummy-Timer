using Rummy_Timer.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rummy_Timer.Models;

namespace Rummy_Timer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPlayersPage : ContentPage
    {
        private ILogic logic = Logic.Logic.GetInstance();
        public AddPlayersPage()
        {
            InitializeComponent();
        }

        public async void OnStart(object value, EventArgs eventArgs) {
            logic.AddPlayer(new Player() { Name = "Alex"});
            logic.AddPlayer(new Player() { Name = "Turin"} );

            logic.Start();

            await Navigation.PushModalAsync(new StartPage());
        }
    }
}