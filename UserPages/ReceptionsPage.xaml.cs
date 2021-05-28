using SalonApp.Menu;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.UserPages
{
    public partial class ReceptionsPage : Page
    {
        public ReceptionsPage()
        { InitializeComponent(); GetTableData(); }
        void ReceptionAdd_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserEditPages.AddReception()); }
        void InMenu_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserMenu()); }
        void Refresh_Click(object sender, RoutedEventArgs e)
        { GetTableData(); }
        void GetTableData()
        {
            DGReceptions.Items.Clear();
            var query = from reception in dbsalonEntities.GetContext().Receptions
                        join client in dbsalonEntities.GetContext().Clients on reception.IdClient equals client.Id
                        where DataBank.UserID == client.IdUser
                        select reception;
            if (query.ToList().Count == 0) Alert.Text = "Записей на прием не найдено";
            else DGReceptions.ItemsSource = query.ToList();
        }
    }
}