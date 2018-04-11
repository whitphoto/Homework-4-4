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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Homework_4_4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TrackPage : Page
    {
        string TrackName;
        public TrackPage()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            TrackName = e.Parameter as string; ;

        }
        private void ShowDataButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.TrackPlayer.HundredMeter = Convert.ToInt32(HundredMeterBox.Text);
            MainPage.TrackPlayer.FiveMile = Convert.ToInt32(FiveMileBox.Text);

            DataBlock.Text = "Player Name = " + TrackName + "\nHeight: " + MainPage.TrackPlayer.height.ToString() + "\n"
    + "Weight: " + MainPage.TrackPlayer.weight.ToString() + "\n100 Meter Time: " + MainPage.TrackPlayer.HundredMeter.ToString()
    + "\n5 Mile Time: " + MainPage.TrackPlayer.FiveMile.ToString();
        }
    }
}
