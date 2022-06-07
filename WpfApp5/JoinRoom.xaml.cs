using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp5;

public partial class JoinRoom : Window
{
    private List<string> _rooms = new List<string>();
    private bool _flag = true;

    public JoinRoom()
    {
        InitializeComponent();
    }


    private void Refresh_OnClick(object sender, RoutedEventArgs e)
    {
        List<string> serverRooms = new List<string>(); //list of rooms on the server
        //TODO: get from server list og rooms
        List<string> newRooms = new_rooms(serverRooms); // get rooms to add
        List<string> removeRooms = remove_rooms(serverRooms);//get  rooms to remove
        if (newRooms.Count > 0) // if there are rooms to add
        {
            for (int i = 0; i < newRooms.Count; i++) // add new rooms
            {
                _rooms.Add(newRooms[i]); // add room to list
                this.RoomsList.Items.Add(newRooms[i]); // add room to listbox
            }
        }

        if (removeRooms.Count > 0) // if there are  rooms to remove
        {
            for (int i = 0; i < removeRooms.Count; i++) // remove rooms
            {
                _rooms.Remove(removeRooms[i]); // remove room from list
                this.RoomsList.Items.Remove(removeRooms[i]); // remove room from listbox
            }
        }
    }

    private List<string> remove_rooms(List<string> serverRooms)
    {
        List<string> newRooms = new List<string>();
        newRooms.Add("room1"); // example 
        // TODO: check if there are rooms to remove
        return newRooms;
    }

    private List<string> new_rooms(List<string> serverRooms)
    {
        List<string> newRooms = new List<string>();
        newRooms.Add("room1"); // example
        newRooms.Add("room2"); // example
        newRooms.Add("room3"); // example
        newRooms.Add("room4"); // example
        // TODO: check if there are new rooms
        return newRooms; // return  list of new rooms
    }

    private void Join_Room_OnClick(object sender, RoutedEventArgs e)
    {
        // TODO: check if room full
        string? roomName = this.RoomsList.SelectedItem.ToString(); // get room name
        if (roomName != null)
        {
            WaitingRoom window = new WaitingRoom(roomName); // create a new window
            window.Show(); // show the new window
            this.Close(); // close the current window
        }
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

    private void Check_Choosing_Room(object sender, SelectionChangedEventArgs e)
    {
        // enable the join button if the user choose a room
        this.joinRoom.IsEnabled = this.RoomsList.SelectedIndex >= 0;
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