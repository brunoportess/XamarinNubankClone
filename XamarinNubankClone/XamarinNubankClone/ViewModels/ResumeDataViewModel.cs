using System.Diagnostics;
using Xamarin.Forms;
using XamarinNubankClone.ViewModels.CreditCard;

namespace XamarinNubankClone.ViewModels
{
    public class ResumeDataViewModel : BaseViewModel
    {
        public Command<HomeType> NavigateCommand { get; set; }
        public string Title { get; set; }
        public double MainValue { get; set; }
        public string MainValueLegend { get; set; }
        public string ResumeDescription { get; set; }
        public HomeType ResumeType { get; set; }

        public ResumeDataViewModel()
        {
            NavigateCommand = new Command<HomeType>(NavigateCommandExecute);
        }

        private async void NavigateCommandExecute(HomeType type)
        {
            switch (type)
            {
                case ResumeDataViewModel.HomeType.Account:
                    break;
                case ResumeDataViewModel.HomeType.CreditCard:
                    await Navigation.PushModalAsync<CreditCardHomeViewModel>();
                    break;
                case ResumeDataViewModel.HomeType.Rewards:
                    break;
                default:
                    break;
            }
        }

        public enum HomeType
        {
            Account,
            CreditCard,
            Rewards
        }
    }
}
