using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinNubankClone.Models
{
    public class ResumeDataModel
    {
        public string Title { get; set; }
        public double MainValue { get; set; }
        public string MainValueLegend { get; set; }
        public string ResumeDescription { get; set; }
        public HomeType ResumeType { get; set; }

        public enum HomeType
        {
            Account,
            CreditCard,
            Rewards
        }
    }
}
