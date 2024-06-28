using System.Windows.Media;
using Wpf.Ui.Controls;
using x.brxxed.UI.Models;

namespace x.brxxed.UI.ViewModels.Pages
{
    public partial class LibraryViewModel : ObservableObject, INavigationAware
    {
        private bool _isInitialized = false;

        [ObservableProperty]
        private IEnumerable<DataColor> _colors;

        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }

        public void OnNavigatedFrom() { }

        private void InitializeViewModel()
        {
            _isInitialized = true;
        }
    }
}
