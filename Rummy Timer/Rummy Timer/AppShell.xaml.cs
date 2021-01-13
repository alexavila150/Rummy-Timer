using Rummy_Timer.ViewModels;
using Rummy_Timer.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Rummy_Timer
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
