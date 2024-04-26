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
using System.Web;
using System.Net;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace brxxedXClient.Pages.GamePages
{
    /// <summary>
    /// Interaction logic for InstallationWindow_LifeIsStrange3.xaml
    /// </summary>
    public partial class InstallationWindow_LifeIsStrange3 : Window
    {
        public InstallationWindow_LifeIsStrange3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (WebClient myWebClient = new WebClient())
            {
                myWebClient.DownloadFileAsync(new Uri("https://public.ph.files.1drv.com/y4mt-Bc-l6omKh1GC05DwUNDMDj8ioqOGlz1Jwc4xcGkuF152ISc32rIy2Vem89uNsewomDDbycYrJRijMr00L9EM3d78hLg0QeYhW5kj8C5R9KFrKG4uzIzFy5hHyfWGVuvp2FovOPQ-FPslI742w65B24Eur_8IBu4RNc9hiIR6eT4MR5Vh2R31tQIPOTXq0X1E8eszczcToEiPdChBgyzImliM1RQmVVmEALFYhEFA4?AVOverride=1"), @"C:\Program Files (x86)\brxxed\X\apps\downloading\LifeIsStrange3Game.rar");
                this.Inst.Content = "Downloading from brxxed servers (Philippines)";
                myWebClient.DownloadDataCompleted += DownloadCompleted;
            }



            void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
            {
                this.Inst.Content = "Downloaded! Now extracting";   
            }

        }
    }
}
