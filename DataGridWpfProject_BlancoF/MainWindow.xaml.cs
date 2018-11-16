using DataGridWpfProject_BlancoF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridWpfProject_BlancoF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ObservableCollections update its contents better in WPF than Lists
        ObservableCollection<Restaurant> restaurants;
        public MainWindow()
        {
            InitializeComponent();

            restaurants = new ObservableCollection<Restaurant>()
            {
                new Restaurant { Name = "McDonalds", Type = RestaurantType.AMERICAN, Phone = "(801) 555-5555",
                    Address = "Main St", Rating = 5, Open = true },
                new Restaurant { Name = "Carls Jr", Type = RestaurantType.AMERICAN, Phone = "(801) 444-4444",
                    Address = "Center St", Rating = 3, Open = true },
                new Restaurant { Name = "Pizza Hut", Type = RestaurantType.ITALIAN, Phone = "(801) 333-3333",
                    Address = "Apple St", Rating = 2, Open = false},

            };

            //RestaurantDataGrid.ItemsSource = restaurants;
            //DataContext = restaurants;
            MainPanel.DataContext = restaurants;

        }

        private void AddRestaurant_Click(object sender, RoutedEventArgs e)
        {
            Restaurant restaurant = new Restaurant() {
                Name = "Default",
                Type = RestaurantType.UNKNOWN,
                Phone = "000-000-0000",
                Address = "1st street",
                Rating = 0,
                Open = false
            };
            restaurants.Add(restaurant);
        }
    }
}
