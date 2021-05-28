using SalonApp.Menu;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.UserPages
{
    public partial class MastersPage : Page
    {
        public MastersPage()
        {
            InitializeComponent();
            DGMasters.ItemsSource = dbsalonEntities.GetContext().Masters.ToList();
        }

        void InMenu_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserMenu()); }
    }
}