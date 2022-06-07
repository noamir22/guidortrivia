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
namespace WpfApp5;

public partial class SighUp : Window
{
    bool flag = true;
    public SighUp()
    {
        InitializeComponent();
    }

    private void SighUp_OnClick(object sender, RoutedEventArgs e)
    {
        string username = new string(this.UsernameBox.Text);
        string email = new string(this.EmailBox.Text);
        string password = new string(this.PasswordBox.Password.ToString());
        // TODO: send to the server the data
        Sb.Completed += new EventHandler(move_to_login);
        Sb.Begin();
    }
    void move_to_login(object? sender, EventArgs e)
    {
        if (!flag) return;
        flag = false;
        Login window = new Login();
        this.Close();
        window.Show();
    }

    private void Quit_OnClick(object sender, RoutedEventArgs e)
    {
        //TODO: disconnect from the server
        Sb.Completed += new EventHandler(Sb_Completed);
        Sb.Begin();
    }

    void Sb_Completed(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void Login_OnClick(object sender, RoutedEventArgs e)
    {
        Sb.Completed += new EventHandler(move_to_login);
        Sb.Begin();
    }
}