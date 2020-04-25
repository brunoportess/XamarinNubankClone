using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNubankClone.ViewModels.Account;

namespace XamarinNubankClone.Views.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelpPage : ContentPage
    {
        public HelpPage()
        {
            InitializeComponent();
            BindingContext = new HelpViewModel();
        }

        private void ClosePage_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}