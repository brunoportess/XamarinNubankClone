using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNubankClone.Views.Home;

namespace XamarinNubankClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage
            {
                BindingContext = new ViewModels.Home.HomeViewModel()
            };
                
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
