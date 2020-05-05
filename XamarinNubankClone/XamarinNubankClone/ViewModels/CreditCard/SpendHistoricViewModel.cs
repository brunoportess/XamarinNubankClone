using System;
using System.Collections.Generic;
using System.Text;
using XamarinNubankClone.Models;

namespace XamarinNubankClone.ViewModels.CreditCard
{
    public class SpendHistoricViewModel : BaseViewModel
    {
        private List<CreditCardItemTimeLineModel> _ItemsTimeline;

        public List<CreditCardItemTimeLineModel> ItemsTimeline
        {
            get { return _ItemsTimeline; }
            set { SetProperty(ref _ItemsTimeline, value); }
        }

        public SpendHistoricViewModel()
        {
            Populate();
        }

        private void Populate()
        {
            ItemsTimeline = new List<CreditCardItemTimeLineModel>();
            var DataItems = new List<CreditCardItemTimeLineModel>
            {
                new CreditCardItemTimeLineModel
                {
                    Title = "Mc Donalds",
                    Subtitle = "R$ 30,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Mc Donalds",
                    Subtitle = "R$ 30,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Mania de bolsa",
                    Subtitle = "R$ 52,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Restaurante dudu",
                    Subtitle = "R$ 72,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Supermercado Araujo",
                    Subtitle = "R$ 152,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Padaria da lalá",
                    Subtitle = "R$ 12,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Lanchonete ao lado",
                    Subtitle = "R$ 17,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Restaurante maná",
                    Subtitle = "R$ 12,40"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Padaria da lalá",
                    Subtitle = "R$ 12,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Mc Donalds",
                    Subtitle = "R$ 30,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Supermercado Araujo",
                    Subtitle = "R$ 152,00"
                },
                new CreditCardItemTimeLineModel
                {
                    Title = "Mc Donalds",
                    Subtitle = "R$ 30,00",
                    IsLast = true
                }
            };

            ItemsTimeline = DataItems;
        }
    }
}
