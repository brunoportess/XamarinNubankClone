
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNubankClone.ViewModels.Home.CustomCell;

namespace XamarinNubankClone.Views.Home.CustomCell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditCardHomeCell : ContentView
    {
        public CreditCardHomeCell()
        {
            InitializeComponent();
            this.BindingContext = new CreditCardHomeViewModel();
        }
    }
}