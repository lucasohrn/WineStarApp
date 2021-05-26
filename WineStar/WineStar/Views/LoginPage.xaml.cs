using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineStar.Models;
using WineStar.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WineStar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            Account user = new Account(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login Failed", "Ok");
            }
        }
    }
}