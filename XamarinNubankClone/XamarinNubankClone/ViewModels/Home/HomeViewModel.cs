using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinNubankClone.ViewModels.Home
{
	public class HomeViewModel : BaseViewModel
    {
		public Command PageSelectedCommand { get; set; }

		private string _compraRecente;
		public string CompraRecente
		{
			get { return _compraRecente; }
			set { SetProperty(ref _compraRecente, value); }
		}

		private List<ResumeDataViewModel> _resumeData;

		public List<ResumeDataViewModel> ResumeData
		{
			get { return _resumeData; }
			set { SetProperty(ref _resumeData, value); }
		}

		private List<MenuOptionViewModel> _MenuOptions;

		public List<MenuOptionViewModel> MenuOptions
		{
			get { return _MenuOptions; }
			set { SetProperty(ref _MenuOptions, value); }
		}

		public HomeViewModel()
		{
			CompraRecente = "Compra recente na sorveteria Tudo Gelador no valor de R$ 36,90";
			PageSelectedCommand = new Command(PageSelectedCommandExecute);
			PopulateResumeData();
			PopulateMenuOptions();
		}


		private async void PageSelectedCommandExecute()
		{
			await DisplayAlert("Teste", "TESTE", "OK");
		}

		private void PopulateMenuOptions()
		{
			MenuOptions = new List<MenuOptionViewModel>
			{
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Indicar amigos"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Recarga de celular"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Cobrar"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Empréstimos"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Depositar"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Transferir"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Ajustar limite"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Me ajuda"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Pagar"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Bloquear cartão"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Cartão virtual"
				},
				new MenuOptionViewModel(PageSelectedCommand)
				{
					MenuIcon = "",
					MenuText = "Organizar atalhos"
				}
			};
		}

		private void PopulateResumeData()
		{
			ResumeData = new List<ResumeDataViewModel>
			{
				new ResumeDataViewModel(PageSelectedCommand)
				{
					MainValue = 2002.46,
					MainValueLegend = "3793.44",
					ResumeDescription = "Compra mais recente em Drogaria",
					ResumeType = ResumeDataViewModel.HomeType.CreditCard,
					Title = "Cartão de crédito"
				},
				new ResumeDataViewModel(PageSelectedCommand)
				{
					MainValue = 2002.46,
					MainValueLegend = "3793.44",
					ResumeDescription = "Compra mais recente em Drogaria",
					ResumeType = ResumeDataViewModel.HomeType.Account,
					Title = "Cartão de crédito"
				},
				new ResumeDataViewModel(PageSelectedCommand)
				{
					MainValue = 2002.46,
					MainValueLegend = "3793.44",
					ResumeDescription = "Compra mais recente em Drogaria",
					ResumeType = ResumeDataViewModel.HomeType.Rewards,
					Title = "Cartão de crédito"
				}
			};

		}
	}
}
