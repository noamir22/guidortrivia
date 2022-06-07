using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace WpfApp5;

public partial class Avatar : Window
{
    public Avatar()
    {
        
        InitializeComponent();
        List<string> images = new List<string>();
        string [] fileEntries = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory +"Data\\avatars\\");
        foreach (string fileName in fileEntries)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri(fileName));
            img.Width = 100;
            img.Height = 100;
            maingrid.Children.Add(img);
            Grid.SetRow(img,images.Count % 7);
            Grid.SetColumn(img, images.Count / 7);
            // img.Stretch = Stretch.Fill;
            images.Add(fileName);
                        
        }
        
    }
}