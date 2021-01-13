using Rummy_Timer.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Rummy_Timer.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}