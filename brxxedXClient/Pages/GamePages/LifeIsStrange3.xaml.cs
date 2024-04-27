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

namespace brxxedXClient.Pages.GamePages
{
    /// <summary>
    /// Interaction logic for LifeIsStrange3.xaml
    /// </summary>
    public partial class LifeIsStrange3 : Page
    {
        public LifeIsStrange3()
        {
            InitializeComponent();
        }


        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDonate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            HomePage libPage = new HomePage();
            NavigationService.Navigate(libPage);
        }

        private void ButtonLibrary_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Install_Click(object sender, RoutedEventArgs e)
        {
            InstallationWindow_LifeIsStrange3 lisinstall = new InstallationWindow_LifeIsStrange3();
            lisinstall.Show(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Undertale_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
