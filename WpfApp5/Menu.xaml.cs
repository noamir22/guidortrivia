using System;
using System.Windows;
// using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using System.Collections;
using System.Windows.Input;

namespace WpfApp5;
public partial class Menu : Window
{
    private bool _flag = true;

    public Menu()
    {
        InitializeComponent();
        string currentAvatar = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Data\\currentAvatar");
        ImageAvatar.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(currentAvatar)!;
        App.Start_animation(Gif);
    }

    private void Join_Room_OnClick(object sender, RoutedEventArgs e)
    {
        
        Sb.Completed += new EventHandler(move_to_join_room); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void move_to_join_room(object? sender, EventArgs e)
    {
        if (!_flag) return; // the animation will not be play again
        _flag = false;
        JoinRoom window = new JoinRoom(); // create a new window
        this.Close(); // close the current window
        window.Show(); // show the new window
    }

    private void My_Status_OnClick(object sender, RoutedEventArgs e)
    {
        Sb.Completed += new EventHandler(move_to_my_status); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void move_to_my_status(object? sender, EventArgs e)
    {
        if (!_flag) return; // the animation will not be play again
        _flag = false;
        MyStatus window = new MyStatus(); // create a new window
        this.Close(); // close the current window
        window.Show(); // show the new window
    }

    private void Quit_OnClick(object sender, RoutedEventArgs e)
    {
        // TODO: send exit to server 
        // when the user click the quit button, the animation will be play.
        // when the animation is completed the window will be closed.
        Sb.Completed += new EventHandler(Sb_Completed); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
        
    }

    private void Sb_Completed(object? sender, EventArgs e)
    {
        this.Close(); // close the current window
    }

    private void Create_Room_OnClick(object sender, RoutedEventArgs e)
    {
        Sb.Completed += new EventHandler(move_to_create_room); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void move_to_create_room(object? sender, EventArgs e)
    {
        if (!_flag) return; // the animation will not be play again
        _flag = false;
        CreateRoom window = new CreateRoom(); // create a new window
        this.Close(); // close the current window
        window.Show(); // show the new window
    }

    private void Best_Score_OnClick(object sender, RoutedEventArgs e)
    {
        Sb.Completed += new EventHandler(move_to_best_score); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void move_to_best_score(object? sender, EventArgs e)
    {
        if (!_flag) return; // the animation will not be play again
        _flag = false;
        BestScores window = new BestScores(); // create a new window
        this.Close(); // close the current window
        window.Show(); // show the new window
    }

    private void Avatar_OnClick(object sender, RoutedEventArgs e)
    {
        Sb.Completed += new EventHandler(move_to_avatar); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void move_to_avatar(object? sender, EventArgs e)
    {
        if (!_flag) return; // the animation will not be play again
        _flag = false;
        Avatar window = new Avatar(); // create a new window
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