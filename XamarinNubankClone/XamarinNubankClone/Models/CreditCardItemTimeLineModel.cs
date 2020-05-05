using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinNubankClone.Models
{
    public class CreditCardItemTimeLineModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public bool IsLast { get; set; } = false;
    }
}
