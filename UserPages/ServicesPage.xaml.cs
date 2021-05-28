using SalonApp.Menu;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.UserPages
{
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
            DGServices.ItemsSource = dbsalonEntities.GetContext().Services.ToList();
        }

        void InMenu_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new UserMenu());
        }
    }
}