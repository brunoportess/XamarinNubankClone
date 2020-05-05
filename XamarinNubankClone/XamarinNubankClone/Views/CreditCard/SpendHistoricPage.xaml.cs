
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNubankClone.ViewModels.CreditCard;

namespace XamarinNubankClone.Views.CreditCard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpendHistoricPage : ContentPage
    {
        public SpendHistoricPage()
        {
            InitializeComponent();
            BindingContext = new SpendHistoricViewModel();
            spendPage.TranslateTo(spendPage.Width, 0, 250, Easing.Linear);
        }

        private void SwipeGestureRecognizer_Swiped_Hide(object sender, SwipedEventArgs e)
        {
            spendPage.TranslateTo(-spendPage.Width, 0, 250, Easing.Linear);
        }
    }
}