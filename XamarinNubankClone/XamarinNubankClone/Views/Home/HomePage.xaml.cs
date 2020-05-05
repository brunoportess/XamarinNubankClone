
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNubankClone.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        bool isExpanded = false;
        Rectangle expandedRect; // bounds for expanded image view
        Rectangle detailsRect;  // bounds for details image view
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            accountPage.FadeTo(.01, 250, Easing.SinInOut);
        }

        void Account_Tapped(object sender, System.EventArgs e)
        {
            if (isExpanded)
                AnimateIn();
            else
                AnimateOut();

            isExpanded = !isExpanded;
        }

        //SOBE
        private void AnimateIn()
        {
            Resumes.TranslateTo(0, 0, 600, Easing.Linear);
            optionsMenu.TranslateTo(0, 0, 600, Easing.Linear);
            accountPage.FadeTo(.01, 900, Easing.SinInOut);
            arrow_menu.RotateXTo(0);
        }

        //DESCE
        private void AnimateOut()
        {
            optionsMenu.TranslateTo(0, gridPage.Height, 600, Easing.Linear);
            accountPage.FadeTo(1, 900, Easing.SinInOut);
            arrow_menu.RotateXTo(180);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            detailsRect = new Rectangle(0, 0, width, carouselMenu.Bounds.Top + 20);
            expandedRect = new Rectangle(0, 0, width, height);

            if (isExpanded)
            {
                carouselMenu.TranslationY = carouselMenu.Height;
            }
            else
            {
                carouselMenu.TranslationY = 0;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            if (isExpanded)
                AnimateIn();
            else
                AnimateOut();

            isExpanded = !isExpanded;
        }
    }
}