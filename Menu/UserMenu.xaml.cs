using SalonApp.UserPages;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.Menu
{
    public partial class UserMenu : Page
    {
        public UserMenu() { InitializeComponent(); }
        void Profile_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ProfilePage()); }
        void Masters_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new MastersPage()); }
        void Products_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ProductsPage()); }
        void Services_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ServicesPage()); }
        void Receptions_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ReceptionsPage()); }
    }
}