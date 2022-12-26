using MathCore.WPF.ViewModels;

namespace Bookinist.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        #region string - Заголовок окна.
        private string _Title = "Главное окно программы";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
    }
}
