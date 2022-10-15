﻿using AngleSharp.Dom;
using EO.WebBrowser.DOM;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using Xamarin.Forms;
using Image = System.Windows.Controls.Image;

namespace WpfApp2
{
    public partial class MainWindow : System.Windows.Window
    {
        public string Path { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Path = "";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String filename = "ScreenCapture-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".png";
         
            int screenLeft = (int)SystemParameters.VirtualScreenLeft;

            int screenTop = (int)SystemParameters.VirtualScreenTop;

            int screenWidth = (int)SystemParameters.VirtualScreenWidth;

            int screenHeight = (int)SystemParameters.VirtualScreenHeight;
            Bitmap bitmap_Screen = new Bitmap(screenWidth, screenHeight);

            Graphics g = Graphics.FromImage(bitmap_Screen);

            g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap_Screen.Size);

            Path = "C:\\Users\\Gulm_be75\\source\\repos\\WpfApp2\\WpfApp2\\Images\\"+filename ;
            bitmap_Screen.Save(Path);

            Image finalImage = new Image();
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(Path);
            logo.EndInit();
            finalImage.Source = logo;
            photo.Source = logo;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
