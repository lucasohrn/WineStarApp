using System;
using System.Collections.Generic;
using System.ComponentModel;
using WineStar.Models;
using WineStar.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WineStar.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}