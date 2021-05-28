using SalonApp.AdminPages;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.Menu
{
    public partial class AdminMenu : Page
    {
        public AdminMenu() { InitializeComponent(); }
        void Clients_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ClientsAdminPage()); }
        void Masters_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new MastersAdminPage()); }
        void Products_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ProductsAdminPage()); }
        void Services_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ServicesAdminPage()); }
        void Receptions_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ReceptionsAdminPage()); }
    }
}