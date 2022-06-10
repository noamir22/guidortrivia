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

public partial class UnlockAvatar : Window
{
    public UnlockAvatar()
    {
        InitializeComponent();
        Sb.Completed +=
            new EventHandler(show_new_avatar); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void show_new_avatar(object? sender, EventArgs e)
    {
        string currentAvatar = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Data\\unlocked");
        string[] keyvalue = currentAvatar.Split('\n');
        List<int> lockedAvatars = new List<int>();
        for (int i = 1; i < keyvalue.Length; i = i + 2)
        {
            if (keyvalue[i] == "false\r")
            {
                string x = keyvalue[i];
                lockedAvatars.Add(i);
            }
        }

        Random rd = new Random();
        int rand_num = rd.Next(0, lockedAvatars.Count);
        int rand_avatar = lockedAvatars[rand_num];
        keyvalue[rand_avatar] = "true\r";
        string newAvatar = keyvalue[rand_avatar - 1];
        Image.Source =
            new System.Windows.Media.Imaging.BitmapImage(new Uri(newAvatar.Substring(1, newAvatar.Length - 3)));
        string tosave = "";
        for (int i = 0; i < keyvalue.Length; i++)
        {
            tosave += keyvalue[i] + "\n";
        }

        System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Data\\unlocked", tosave);
    }
}