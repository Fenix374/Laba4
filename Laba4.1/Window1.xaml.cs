using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Laba5
{
    public partial class Window1 : Window
    {
        private DataSet dataSet = new DataSet();

        public Window1()
        {
            InitializeComponent();
            FillPlatformComboBox();
        }

        private void FillPlatformComboBox()
        {
                using (var connection = new SqlConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand("FAM", connection))
                    {
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataSet, "Platforms");

                            foreach (DataRow row in dataSet.Tables["Platforms"].Rows)
                            {
                                PlatformComboBox.Items.Add(row["PLATFORMS"].ToString());
                            }

                            PlatformComboBox.Items.Insert(0, "Filter by Platform...");
                            PlatformComboBox.SelectedIndex = 0;
                        }
                    }
                }

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                
                    using (var connection = new SqlConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand("SELECT * FROM GAMES WHERE TITLE LIKE @SearchText OR PLATFORMS LIKE @SearchText", connection))
                        {
                            command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                            using (var adapter = new SqlDataAdapter(command))
                            {
                                dataSet.Tables["Games"].Clear();
                                adapter.Fill(dataSet, "Games");
                            }
                        }
                    }
                
            }

        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            string platformFilter = PlatformComboBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(platformFilter) && platformFilter != "Filter by Platform...")
            {
                    using (var connection = new SqlConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand("SELECT * FROM GAMES WHERE PLATFORMS = @Platform", connection))
                        {
                            command.Parameters.AddWithValue("@Platform", platformFilter);
                            using (var adapter = new SqlDataAdapter(command))
                            {
                                dataSet.Tables["Games"].Clear();
                                adapter.Fill(dataSet, "Games");
                            }
                        }
                    }
                }
        }
    }
}
