using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinNubankClone.ViewModels.Home.CustomCell
{
    public class CreditCardHomeViewModel : BaseViewModel
    {
        public Command PageSelectedCommand { get; set; }
        
        private string _compraRecente;
        public string CompraRecente
        {
            get { return _compraRecente; }
            set { SetProperty(ref _compraRecente, value); }
        }

        public CreditCardHomeViewModel()
        {
            PageSelectedCommand = new Command(PageSelectedCommandExecute);
            CompraRecente = "Compra recente na sorveteria Tudo Gelador no valor de R$ 36,90";
        }

        private async void PageSelectedCommandExecute()
        {
            Debug.WriteLine("abacaxi");
            await Navigation.PushAsync<XamarinNubankClone.ViewModels.CreditCard.CreditCardHomeViewModel>();
        }
    }
}
