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
    public sealed partial class TennisPage : Page
    {
        string TennisName;
        public TennisPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string TennisName = e.Parameter as string;
    }

        private void ShowData_Click(object sender, RoutedEventArgs e)
        {
            MainPage.TennisPlayer.PlayerRating = Convert.ToDouble (PlayerRankBox.Text);
            MainPage.TennisPlayer.CurrentRanking = Convert.ToInt32(CurrentRankBox.Text);

            DataBlock.Text = "Player Name = " + TennisName + "\nHeight: " + MainPage.TennisPlayer.height.ToString() + "\n"
                + "Weight: " + MainPage.TennisPlayer.weight.ToString() + "\nPlayer Ranking: " + MainPage.TennisPlayer.PlayerRating.ToString()
                + "\nCurrent Ranking: " + MainPage.TennisPlayer.CurrentRanking.ToString();
        }
    }
}
