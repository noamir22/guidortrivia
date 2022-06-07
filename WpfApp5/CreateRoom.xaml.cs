using System;
using System.Windows;

namespace WpfApp5;

public partial class CreateRoom : Window
{
    private bool _flag = true;
    public CreateRoom()
    {
        InitializeComponent();
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

    private void Create_OnClick(object sender, RoutedEventArgs e)
    {
        // when the user click the sign up button, the animation will be play.
        // when the animation is completed the window will be closed and the sign up window will be opened
        Sb.Completed += new EventHandler(move_to_waiting_room_host); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void move_to_waiting_room_host(object? sender, EventArgs e)
    {
        // the animation will not be play again
        if (!_flag) return;
        _flag = false;

        WaitingRoomHost window = new WaitingRoomHost(); // create a new window
        this.Close(); // close the current window
        window.Show(); // show the new window
    }
}