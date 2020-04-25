using Xamarin.Forms;
using XamarinNubankClone.Controls;

namespace XamarinNubankClone.ViewModels.Account
{
    public class AccountViewModel :BaseViewModel
    {
        public Command<string> NavigateCommand { get; set; }
        public AccountViewModel()
        {
            NavigateCommand = new Command<string>(NavigateCommandExecute);
        }

        private async void NavigateCommandExecute(string page)
        {
            switch (page)
            {
                case "help":
                    await Navigation.PushModalAsync<HelpViewModel>(TransitionType.SlideFromBottom);
                    break;
                case "profile":
                    await Navigation.PushModalAsync<ProfileViewModel>(TransitionType.SlideFromBottom);
                    break;
                default:
                    break;
            }
        }
    }
}
