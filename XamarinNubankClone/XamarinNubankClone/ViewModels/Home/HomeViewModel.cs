using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using XamarinNubankClone.Models;

namespace XamarinNubankClone.ViewModels.Home
{
	public class HomeViewModel : BaseViewModel
    {
		public Command PageSelectedCommand { get; set; }


		private List<ResumeDataModel> _resumeData;

		public List<ResumeDataModel> ResumeData
		{
			get { return _resumeData; }
			set { SetProperty(ref _resumeData, value); }
		}

		private List<MenuOptionModel> _MenuOptions;

		public List<MenuOptionModel> MenuOptions
		{
			get { return _MenuOptions; }
			set { SetProperty(ref _MenuOptions, value); }
		}

		public HomeViewModel()
		{
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
			MenuOptions = new List<MenuOptionModel>
			{
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Indicar amigos"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Recarga de celular"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Cobrar"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Empréstimos"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Depositar"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Transferir"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Ajustar limite"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Me ajuda"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Pagar"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Bloquear cartão"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Cartão virtual"
				},
				new MenuOptionModel
				{
					MenuIcon = "",
					MenuText = "Organizar atalhos"
				}
			};
		}

		private void PopulateResumeData()
		{
			ResumeData = new List<ResumeDataModel>
			{
				new ResumeDataModel
				{
					MainValue = 2002.46,
					MainValueLegend = "3793.44",
					ResumeDescription = "Compra mais recente em Drogaria",
					ResumeType = ResumeDataModel.HomeType.CreditCard,
					Title = "Cartão de crédito"
				},
				new ResumeDataModel
				{
					MainValue = 2002.46,
					MainValueLegend = "3793.44",
					ResumeDescription = "Compra mais recente em Drogaria",
					ResumeType = ResumeDataModel.HomeType.Account,
					Title = "Cartão de crédito"
				},
				new ResumeDataModel
				{
					MainValue = 2002.46,
					MainValueLegend = "3793.44",
					ResumeDescription = "Compra mais recente em Drogaria",
					ResumeType = ResumeDataModel.HomeType.Rewards,
					Title = "Cartão de crédito"
				}
			};

		}
	}
}
