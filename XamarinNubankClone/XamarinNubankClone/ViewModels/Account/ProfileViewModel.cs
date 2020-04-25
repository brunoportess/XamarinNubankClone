using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinNubankClone.ViewModels.Account
{
    public class ProfileViewModel : BaseViewModel
    {
        public ICommand GoBackCommand => new Command(GoBackCommandExecute);
        public ProfileViewModel()
        {
            Debug.WriteLine("OK");
        }

        async void GoBackCommandExecute()
        {
            await Navigation.PopModalAsync();
        }
    }
}
