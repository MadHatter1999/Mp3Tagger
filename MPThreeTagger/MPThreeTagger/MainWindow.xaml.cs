using Microsoft.Win32;
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

namespace MPThreeTagger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        String Active_MP3_URL = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_MP3(object sender, RoutedEventArgs e)
        {
            

            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Music (.mp3)|*.mp3";
            File.ShowDialog(); 
            if (File.CheckPathExists)
            {
                //Process Mp3 File
                Active_MP3_URL = File.FileName;
                test.Text = "Loaded: "+Active_MP3_URL;
            }

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void Save(object sender, RoutedEventArgs e)
        {
            //Checks to see if a Song is loaded
            if (Active_MP3_URL!=null)
            {
               
            }
        }
    }
}
