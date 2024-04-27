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
using System.Windows.Shapes;
using brxxedXClient;
namespace brxxedXClient
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ButtonDonate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLibrary_Click(object sender, RoutedEventArgs e)
        {
            //LibraryPage li3bPage = new LibraryPage();
            //string libPage = "Pages/LibraryPage.xaml";
        }


        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            //HomePage homePage = new HomePage();
            //Frame pageFrame = new Frame();
            //pa`geFrame.Source = homePage;
        }


        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
