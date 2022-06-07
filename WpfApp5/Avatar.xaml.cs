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
    private bool _flag = true;
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

    private void Back_OnClick(object sender, RoutedEventArgs e)
    {
        // when the user click the sign up button, the animation will be play.
        // when the animation is completed the window will be closed and the sign up window will be opened
        Sb.Completed += new EventHandler(move_to_menu); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation

    }

    private void move_to_menu(object? sender, EventArgs e)
    {
        // the animation will not be play again
        if (!_flag) return;
        _flag = false;

        Menu window = new Menu(); // create a new window
        this.Close(); // close the current window
        window.Show(); // show the new window
    }
}