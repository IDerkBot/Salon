using SalonApp.Menu;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.UserPages
{
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        {
            InitializeComponent();
            DGProducts.ItemsSource = dbsalonEntities.GetContext().Products.OrderBy(x => x.Id).Skip(1).ToList();
        }
        void InMenu_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserMenu()); }
    }
}