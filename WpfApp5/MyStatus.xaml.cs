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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MyStatus.xaml
    /// </summary>
    public partial class MyStatus : Window
    {
        private bool _flag = true;
        public MyStatus()
        {
            InitializeComponent();
            App.Start_animation(Gif);

            // TODO: get from the server the current status of the user
            NumberOfGame.Content = "Number of Games: " + "0";
            NumberOfRightAnswers.Content = "Number of Right Answers: " + "0";
            NumberOfWrongAnswers.Content = "Number of Wrong Answers: " + "0";
            AverageTimePerAnswer.Content = "Average Time Per Answer: " + "0";
            
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
}
