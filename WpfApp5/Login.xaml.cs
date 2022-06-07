using System;
using System.Windows;


namespace WpfApp5;
// Amir: add sound 
public partial class Login : Window
{
    private bool _flag = true;

    public Login()
    {
        InitializeComponent();
    }

    private void SighUp_OnClick(object sender, RoutedEventArgs e)

    {
        // when the user click the sign up button, the animation will be play.
        // when the animation is completed the window will be closed and the sign up window will be opened
        Sb.Completed += new EventHandler(move_to_signup); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void move_to_signup(object? sender, EventArgs e)
    {
        // the animation will not be play again
        if (!_flag) return;
        _flag = false;

        SighUp window = new SighUp(); // create a new window
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

    private void Login_OnClick(object sender, RoutedEventArgs e)
    {
        string username = new string(this.Username.Text);
        string password = new string(this.Password.Password.ToString());
        // TODO: login to the server
        // TODO: if the login is successful, the window will be closed and the menu window will be opened
        Sb.Completed += new EventHandler(move_to_menu); // add the event handler to the completed event of the animation
        Sb.Begin(); // start the animation
    }

    private void move_to_menu(object? sender, EventArgs e)
    {
        if (!_flag) return; // the animation will not be play again
        _flag = false;
        Menu window = new Menu(); // create a new window
        this.Close(); // close the current window
        window.Show(); // show the new window
    }
}