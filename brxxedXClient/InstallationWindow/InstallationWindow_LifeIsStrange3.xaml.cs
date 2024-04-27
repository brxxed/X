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
using Notifications.Wpf;
using SharpCompress.Archives.Rar;
using SharpCompress.Common;
using SharpCompress;
using SharpCompress.Archives;
using System.IO;


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
                myWebClient.DownloadFileAsync(new Uri("https://onedrive.live.com/download?resid=3404EE6DFFA6DC43%2168258&authkey=!AD1nECuOiPeBerM"), "LifeIsStrange3.rar");
                this.Inst.Content = "Downloading from brxxed servers";
                myWebClient.DownloadDataCompleted += DownloadCompleted;
                var notificationManager = new NotificationManager();

                notificationManager.Show(new NotificationContent
                {
                    Title = "Life is Strange: True Colors",
                    Message = "brxxed X \n Now downloading",
                    Type = NotificationType.Information
                });
            }
        }




        void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Inst.Content = "Downloaded! Now extracting";
            var notificationManager = new NotificationManager();

            notificationManager.Show(new NotificationContent
            {
                Title = "Life is Strange: True Colors",
                Message = "brxxed X \n Extracting",
                Type = NotificationType.Information
            });

            ExtractGame();
        }
        private void ExtractGame()
        {
            using (var archive = RarArchive.Open("LifeIsStrange3.rar"))
            {
                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                {
                    entry.Archive.WriteToDirectory("C:\\Program Files (x86)\\brxxed\\X\\apps\\installed\\LifeIsStrange3", new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });
   
                }
            }
        }
    }
}


