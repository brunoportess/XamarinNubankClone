using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinNubankClone.ViewModels.Perfil
{
    public class PerfilViewModel : BaseViewModel
    {
        public ICommand GoBackCommand => new Command(GoBackCommandExecute);
        public PerfilViewModel()
        {
            Debug.WriteLine("OK");
        }

        async void GoBackCommandExecute()
        {
            await Navigation.PopModalAsync();
        }
    }
}
