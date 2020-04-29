using System.Windows.Input;

namespace XamarinNubankClone.ViewModels
{
    public abstract class BaseClickableViewModel : BaseViewModel
    {
        public ICommand OnClickedCommand { get; private set; }

        public BaseClickableViewModel(ICommand onClickCommand)
        {
            OnClickedCommand = onClickCommand;
        }
    }
}
