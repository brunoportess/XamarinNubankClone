using System.Collections.Generic;
using XamarinNubankClone.Models;

namespace XamarinNubankClone.ViewModels.Account
{
    public class HelpViewModel : BaseViewModel
    {
        private List<HelpQuestionModel> _ListTopicQuestions;

        public List<HelpQuestionModel> ListTopicQuestions
        {
            get { return _ListTopicQuestions; }
            set { SetProperty(ref _ListTopicQuestions, value); }
        }

        public HelpViewModel()
        {
            PopulateListTopic();
        }

        private void PopulateListTopic()
        {
            ListTopicQuestions = new List<HelpQuestionModel>
            {
                new HelpQuestionModel
                {
                    Title = "Coronavírus",
                    Subtitle = "Dúvidas sobre o coronavírus? Veja aqui"
                },
                new HelpQuestionModel
                {
                    Title = "Novidades",
                    Subtitle = "Tudo sobre o nubank e nossos produtos"
                },
                new HelpQuestionModel
                {
                    Title = "Conta",
                    Subtitle = "Conheça tudo sobre sua conta digital"
                },
                new HelpQuestionModel
                {
                    Title = "Pagar Fatura",
                    Subtitle = "Descubra como e onde pagar sua fatura"
                },
                new HelpQuestionModel
                {
                    Title = "Parcelar Fatura",
                    Subtitle = "Veja como parcelar sua fatura"
                },
                new HelpQuestionModel
                {
                    Title = "Limite de Crédito",
                    Subtitle = "Tire suas dúvidas sobre seu limite de crédito"
                }
            };
        }
    }
}
