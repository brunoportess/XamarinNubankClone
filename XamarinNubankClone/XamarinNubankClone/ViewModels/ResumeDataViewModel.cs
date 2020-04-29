using System.Windows.Input;

namespace XamarinNubankClone.ViewModels
{
    public class ResumeDataViewModel : BaseClickableViewModel
    {
        public string Title { get; set; }
        public double MainValue { get; set; }
        public string MainValueLegend { get; set; }
        public string ResumeDescription { get; set; }
        public HomeType ResumeType { get; set; }

        public ResumeDataViewModel(ICommand onResumeSelected) : base(onResumeSelected)
        {
        }

        public enum HomeType
        {
            Account,
            CreditCard,
            Rewards
        }
    }
}
