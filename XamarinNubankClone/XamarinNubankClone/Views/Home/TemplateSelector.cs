using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinNubankClone.Models;
using XamarinNubankClone.Views.Home.CustomCell;

namespace XamarinNubankClone.Views.Home
{
    public class TemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate CreditCardTemplate;
        private readonly DataTemplate AccountTemplate;
        private readonly DataTemplate RewardsTemplate;

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            ResumeDataModel messageVm = item as ResumeDataModel;
            if (messageVm == null)
                return null;
            switch (messageVm.ResumeType)
            {
                case ResumeDataModel.HomeType.Account:
                    return AccountTemplate;
                case ResumeDataModel.HomeType.CreditCard:
                    return CreditCardTemplate;
                case ResumeDataModel.HomeType.Rewards:
                    return RewardsTemplate;
                default:
                    return null;
            }
        }


        public TemplateSelector()
        {
            CreditCardTemplate = new DataTemplate(typeof(CreditCardHomeCell));
            AccountTemplate = new DataTemplate(typeof(AccountHomeCell));
            RewardsTemplate = new DataTemplate(typeof(RewardsHomeCell));
        }
    }
}
