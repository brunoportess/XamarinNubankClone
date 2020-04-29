using System.Windows.Input;

namespace XamarinNubankClone.ViewModels
{
    public class MenuOptionViewModel : BaseClickableViewModel
    {
        private string menuIcon;
        private string menuText;

        public string MenuIcon
        {
            get => menuIcon;
            set => SetProperty(ref menuIcon, value);
        }

        public string MenuText
        {
            get => menuText;
            set => SetProperty(ref menuText, value);
        }

        public MenuOptionViewModel(ICommand menuOptionSelected) : base(menuOptionSelected)
        {
        }
    }
}
