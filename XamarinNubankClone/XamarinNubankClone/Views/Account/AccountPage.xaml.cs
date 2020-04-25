﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNubankClone.ViewModels.Account;

namespace XamarinNubankClone.Views.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentView
    {
        public AccountPage()
        {
            InitializeComponent();
            BindingContext = new AccountViewModel();
        }

    }
}