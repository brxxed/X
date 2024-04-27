using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using brxxedXClient.Pages.GamePages;

namespace brxxedXClient.Pages
{
    /// <summary>
    /// Interaction logic for LibraryPage.xaml
    /// </summary>
    public partial class LibraryPage : Page
    {
        public LibraryPage()
        {
            InitializeComponent();
        }
        private void ButtonLibrary_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            HomePage libPage = new HomePage();
            NavigationService.Navigate(libPage);
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDonate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void lis_Click(object sender, RoutedEventArgs e)
        {
            LifeIsStrange3 lis = new LifeIsStrange3();
            NavigationService.Navigate(lis);

        }
    }
}

