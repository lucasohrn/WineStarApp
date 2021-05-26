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
            Init();
        }

        void Init()
        {
            ActivitySpinner.IsVisible = false;
            LogoIcon.HeightRequest = 120;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            Account user = new Account(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Succeeded", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login Failed", "Ok");
            }
        }
    }
}