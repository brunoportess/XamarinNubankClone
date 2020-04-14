
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
            //MainImage.LayoutTo(detailsRect, 1200, Easing.SpringOut);
            Resumes.TranslateTo(0, 0, 1200, Easing.SpringOut);
            optionsMenu.TranslateTo(0, 0, 1200, Easing.SpringOut);
            //indicatorView.TranslateTo(0, 0, 1200, Easing.SpringOut);
            //Resumes.FadeTo(1, 250, Easing.SinInOut);
            //optionsMenu.FadeTo(1, 250, Easing.SinInOut);
            accountPage.FadeTo(.01, 250, Easing.SinInOut);
        }

        //DESCE
        private void AnimateOut()
        {
            //MainImage.LayoutTo(expandedRect, 1200, Easing.SpringOut);
            Resumes.TranslateTo(0, gridPage.Height, 1200, Easing.SpringOut);
            optionsMenu.TranslateTo(0, gridPage.Height, 1200, Easing.SpringOut);
            //indicatorView.TranslateTo(-indicatorView.Width, 0, 1200, Easing.SpringOut);
            //Resumes.FadeTo(.01, 250, Easing.SinInOut);
            //optionsMenu.FadeTo(.01, 250, Easing.SinInOut);
            accountPage.FadeTo(1, 250, Easing.SinInOut);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            detailsRect = new Rectangle(0, 0, width, carouselMenu.Bounds.Top + 20);
            expandedRect = new Rectangle(0, 0, width, height);

            if (isExpanded)
            {
                //MainImage.Layout(expandedRect);
                carouselMenu.TranslationY = carouselMenu.Height;
                //Title.TranslationX = -Title.Width;
            }
            else
            {
                //MainImage.Layout(detailsRect);
                carouselMenu.TranslationY = 0;
                //Title.TranslationX = 0;
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