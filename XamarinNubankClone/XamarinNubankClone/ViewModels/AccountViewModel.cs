using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinNubankClone.Controls;
using XamarinNubankClone.ViewModels.Home;
using XamarinNubankClone.ViewModels.Perfil;
using XamarinNubankClone.Views.Perfil;

namespace XamarinNubankClone.ViewModels
{
    public class AccountViewModel :BaseViewModel
    {
        public ICommand PerfilCommand => new Command(PerfilCommandExecute);
        public AccountViewModel()
        {
            
        }

        private async void PerfilCommandExecute(object obj)
        {
            await Navigation.PushModalAsync<PerfilViewModel>(TransitionType.SlideFromBottom);
        }
    }
}
