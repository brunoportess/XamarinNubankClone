using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNubankClone.Views.CreditCard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditCardHomePage : ContentPage
    {
        public CreditCardHomePage()
        {
            InitializeComponent();
            spendPage.TranslateTo(-GridPage.Width, 0, 250, Easing.Linear);
        }

        private void SwipeGestureRecognizer_Swiped_Display(object sender, SwipedEventArgs e)
        {
            spendPage.TranslateTo(0, 0, 250, Easing.Linear);
        }

        private void SwipeGestureRecognizer_Swiped_Hide(object sender, SwipedEventArgs e)
        {
            spendPage.TranslateTo(-GridPage.Width, 0, 250, Easing.Linear);
        }
    }
}