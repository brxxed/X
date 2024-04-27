using Notifications.Wpf;
using SharpCompress.Archives.Rar;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
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
using SharpCompress.Archives;

namespace brxxedXClient.InstallationWindow
{
    /// <summary>
    /// Interaction logic for InstallationWindow_SpiderManMilesMorales.xaml
    /// </summary>
    public partial class InstallationWindow_SpiderManMilesMorales : Window
    {
        public InstallationWindow_SpiderManMilesMorales()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (WebClient myWebClient = new WebClient())
            {
                myWebClient.DownloadFileAsync(new Uri("https://onedrive.live.com/download?resid=3404EE6DFFA6DC43%2168257&authkey=!ALCm81uzILCs"), "SpiderManMilesMorales.rar");
                this.Inst.Content = "Downloading from brxxed servers";
                myWebClient.DownloadDataCompleted += DownloadCompleted;
                var notificationManager = new NotificationManager();

                notificationManager.Show(new NotificationContent
                {
                    Title = "Spider-Man Miles Morales",
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
                Title = "Spider-Man Miles Morales",
                Message = "brxxed X \n Extracting",
                Type = NotificationType.Information
            });

            ExtractGame();
        }
        private void ExtractGame()
        {
            using (var archive = RarArchive.Open("SpiderManMilesMorales.rar"))
            {
                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                {
                    entry.Archive.WriteToDirectory("C:\\Program Files (x86)\\brxxed\\X\\apps\\installed\\Spider-Man Miles Morales", new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });

                }
            }
        }
    }
}
