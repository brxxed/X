using Wpf.Ui.Controls;
using x.brxxed.UI.ViewModels.Pages;

namespace x.brxxed.UI.Views.Pages
{
    public partial class DataPage : INavigableView<LibraryViewModel>
    {
        public LibraryViewModel ViewModel { get; }

        public DataPage(LibraryViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
