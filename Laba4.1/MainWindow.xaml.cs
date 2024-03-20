using Laba4._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Laba5
{
    public partial class MainWindow : Window
    {
        private ASSASINS_CREEDEntities db = new ASSASINS_CREEDEntities();

        public MainWindow()
        {
            InitializeComponent();
            FillPlatformComboBox();
        }

        private void FillPlatformComboBox()
        {

                List<string> platforms = db.GAMES.Select(g => g.PLATFORMS).Distinct().ToList();

                PlatformComboBox.Items.Add("Filter by Platform...");

                foreach (string platform in platforms)
                {
                    PlatformComboBox.Items.Add(platform);
                }

                PlatformComboBox.SelectedIndex = 0;
            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                var games = db.GAMES.Where(g => g.TITLE.Contains(searchText) || g.PLATFORMS.Contains(searchText)).ToList();
                GamesDataGrid.ItemsSource = games;
            }
            
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            string platformFilter = PlatformComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(platformFilter))
            {
                var games = db.GAMES.Where(g => g.PLATFORMS.Equals(platformFilter)).ToList();
                GamesDataGrid.ItemsSource = games;
            }
            
        }
    }
}
