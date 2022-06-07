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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
// using System.Media;

namespace WpfApp5;

public partial class Login : Window
{
    private bool _flag = true;
    public Login()
    {
        InitializeComponent();

        //
        // SoundPlayer player = new SoundPlayer();
        // player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "lobby-classic-game.wav";
        // player.Play();
    }

    private void SighUp_OnClick(object sender, RoutedEventArgs e)
    {
        Sb.Completed += new EventHandler(move_to_signup);
        Sb.Begin();
    }

    private void move_to_signup(object? sender, EventArgs e)
    {
        if (!_flag) return;
        _flag = false;
        SighUp window = new SighUp();
        this.Close();
        window.Show();
    }
    private void Quit_OnClick(object sender, RoutedEventArgs e)
    {
        // TODO: send exit to server 
        Sb.Completed += new EventHandler(Sb_Completed);
        Sb.Begin();
    }
    private void Sb_Completed(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void Login_OnClick(object sender, RoutedEventArgs e)
    {
        string username = new string(this.Username.Text);
        string password = new string(this.Password.Password.ToString());
        // TODO: login to the server
        Sb.Completed += new EventHandler(move_to_menu);
        Sb.Begin();
    }

    private void move_to_menu(object? sender, EventArgs e)
    {
        if (!_flag) return;
        _flag = false;
        Menu window = new Menu();
        this.Close();
        window.Show();
    }
}