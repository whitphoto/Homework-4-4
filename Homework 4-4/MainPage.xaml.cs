using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Homework_4_4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

        public class Sports
            {
               public string name = "Joe Default";
                public int height = 70;
                public int weight = 175;
            }

        public class Tennis : Sports
    {
        public double PlayerRating = 5;
        public int CurrentRanking = 5;

    }

        public class Track : Sports
    {
        public int HundredMeter = 5;
        public int FiveMile = 5;
    }

    

    public sealed partial class MainPage : Page
    {
        public static Tennis TennisPlayer = new Tennis();
        public static Track TrackPlayer = new Track();

        public MainPage()
        {
            this.InitializeComponent();

        }

        private void TennisButton_Click(object sender, RoutedEventArgs e)
        {
            TennisPlayer.name = NameBox.Text;
            TennisPlayer.height = Convert.ToInt32(HeightBox.Text);
            TennisPlayer.weight = Convert.ToInt32(WeightBox.Text);
            Frame.Navigate(typeof(TennisPage), TennisPlayer.name);
        }

        private void TrackButton_Click(object sender, RoutedEventArgs e)
        {
            TrackPlayer.name = NameBox.Text;
            TrackPlayer.height = Convert.ToInt32(HeightBox.Text);
            TrackPlayer.weight = Convert.ToInt32(WeightBox.Text);
            Frame.Navigate(typeof(TrackPage), TrackPlayer.name);
        }
    }
}
