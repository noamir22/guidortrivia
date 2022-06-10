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
    /// Interaction logic for WaitingRoom.xaml
    /// </summary>
    public partial class WaitingRoom : Window
    {
        public string? RoomName;

        public WaitingRoom(string? roomName)
        {
            RoomName = roomName;
            InitializeComponent();
            App.Start_animation(Gif);

        }

        private void Check_Choosing_Room(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
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