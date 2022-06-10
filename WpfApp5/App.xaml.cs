using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static System.Media.SoundPlayer sp;
        protected static bool issound = false;

        protected internal static void Start_animation(MediaElement Gif)
        {
            if (issound)
            {
                Gif.Play();

            }
            else
            {
                Gif.Play();
                System.Threading.Thread.Sleep(100);
                Gif.Stop();
            }
        }
        protected internal static void Radio_OnClick(object sender, RoutedEventArgs e)
        {
            
            MediaElement Gif= sender as MediaElement;
            if (!issound)
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 6);
                sp = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Data\\sound\\"+rand_num+".wav");
                sp.Play();
                issound = true;
                Gif.Position = new TimeSpan(0, 0, 1);
                Gif.Play();
            }
            else
            {
                sp.Stop();
                issound = false;
                Gif.Stop();
            }   
        }
        protected internal static void gif_MediaEnded(object sender, RoutedEventArgs e)
        {   
            MediaElement Gif= sender as MediaElement;
            if (issound)
            {
                Gif.Position = new TimeSpan(0, 0, 1);
                Gif.Play();
            }
        }
    }
}