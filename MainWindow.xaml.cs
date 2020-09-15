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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Store_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            forSaleDataGrid.ItemsSource = Store.forSale;
            shoppingCartDataGrid.ItemsSource = Store.shoppingCart;
        }

        void RefreshMedia()
        {
            forSaleDataGrid.ItemsSource = null;
            forSaleDataGrid.ItemsSource = Store.forSale;
            shoppingCartDataGrid.ItemsSource = null;
            shoppingCartDataGrid.ItemsSource = Store.shoppingCart;
        }

        private void purchase_Click(object sender, RoutedEventArgs e)
        {
            // ((Food)forSaleDataGrid.SelectedItem).Item;
            RefreshMedia();
        }

        private void returnToShelf_Click(object sender, RoutedEventArgs e)
        {
            Store.shoppingCart.Remove((Merchandise)shoppingCartDataGrid.SelectedItem);
            RefreshMedia();
        }
    }
}
