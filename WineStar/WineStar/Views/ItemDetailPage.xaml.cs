using System.ComponentModel;
using WineStar.ViewModels;
using Xamarin.Forms;

namespace WineStar.Views
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