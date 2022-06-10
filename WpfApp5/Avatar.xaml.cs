using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WpfApp5;

public partial class Avatar : Window
{
    private bool _flag = true;

    public Avatar()
    {
        // 
        
        InitializeComponent();
        App.Start_animation(Gif);

        string currentAvatar = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Data\\unlocked");
        string[] keyvalue = currentAvatar.Split('\n');
        List<string> images = new List<string>();
        string [] fileEntries = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory +"Data\\avatars\\");
        // foreach (string fileName in fileEntries)
        for (int i=0; i<fileEntries.Length; i++)
        {
            Image img = new Image();
            if (keyvalue[2 * i + 1] == "true\r")
            {
                img.Source = new BitmapImage(new Uri(fileEntries[i]));
                img.Width = 100;
                img.Height = 100;
                maingrid.Children.Add(img);
                Grid.SetRow(img, images.Count / 7);
                Grid.SetColumn(img, images.Count % 7);
                img.MouseDown += new System.Windows.Input.MouseButtonEventHandler(img_MouseDown);
                images.Add(fileEntries[i]);
            }
            else
            {
                img.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory +"Data\\information.png"));
                img.Width = 100;
                img.Height = 100;
                maingrid.Children.Add(img);
                Grid.SetRow(img, images.Count / 7);
                Grid.SetColumn(img, images.Count % 7);
                images.Add(fileEntries[i]);

            }



        }
        
    }

    private void img_MouseDown(object sender, MouseButtonEventArgs e)
    {
        Image im = sender as Image;
        string path = im.Source.ToString();
        System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Data\\currentAvatar", path);
        Back_OnClick(sender, e);
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
    private void Radio_OnClick(object sender, RoutedEventArgs e)
    {
        App.Radio_OnClick(sender,e);
    }
    private void gif_MediaEnded(object sender, RoutedEventArgs e)
    {
        App.gif_MediaEnded(sender, e);
    }
}