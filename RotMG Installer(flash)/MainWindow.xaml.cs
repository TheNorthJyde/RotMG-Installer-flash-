using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
using System.Net;
using System.IO;

namespace RotMG_Installer_flash_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            fileItems.Items.Add("List of files");
        }
        private async void startInstall_Click(object sender, RoutedEventArgs e)
        {

            fileItems.Items.Add("Flash player 18");

            
            if (!Directory.Exists(@"C:\Users\" +  Environment.UserName + @"\Documents\Realm"))
            {
                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\Realm");
            }

            if (!File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Realm\flashplayer18_sa.exe"))
            {
                
                using (var client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(new Uri("https://github.com/TheNorthJyde/RotMG-flash-installer/blob/master/flashplayer18_sa.exe?raw=true"), @"C:\Users\" + Environment.UserName + @"\Documents\Realm\flashplayer18_sa.exe");
                }

                    
                fileItems.Items[fileItems.Items.Count - 1] += " ✔";

            }
            else
            {
                fileItems.Items[fileItems.Items.Count - 1] += " ✔";
            }

            fileItems.Items.Add("RotMG launcher");
            if (!File.Exists(@"C:\Users\" + Environment.UserName + @"\\Desktop\RotMG.exe"))
            {
                using (var client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(new Uri("https://github.com/TheNorthJyde/RotMG-Installer-flash-/raw/master/RotMG.exe"), @"C:\Users\" + Environment.UserName + @"\Desktop\RotMG.exe");
                }
                fileItems.Items[fileItems.Items.Count - 1] += " ✔";
            }
            else
            {
                fileItems.Items[fileItems.Items.Count - 1] += " ✔";
            }
        }

        





    }
}
