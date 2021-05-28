using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminEditPages
{
    public partial class ClientAddPage : Page
    {
        public ClientAddPage()
        { InitializeComponent(); }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ReceptionEditPage()); }
        void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text == null || Date.SelectedDate == null || Address.Text == null)
                MessageBox.Show("Заполните пожалуйста все поля", "", MessageBoxButton.OK);
            else
            {
                var dateNotTime = Date.SelectedDate.ToString().Split(' ')[0];
                string date = null;
                if (dateNotTime.Contains('/')) date = $"{dateNotTime.Split('/')[1]}.{dateNotTime.Split('/')[0]}.{dateNotTime.Split('/')[2]}";
                else date = $"{dateNotTime.Split('.')[0]}.{dateNotTime.Split('.')[1]}.{dateNotTime.Split('.')[2]}";
                var client = new Client
                { Name = Name.Text, YearOfBirth = date, Address = Address.Text };
                dbsalonEntities.GetContext().Clients.Add(client);
                dbsalonEntities.GetContext().SaveChanges();
                MessageBox.Show("Клиент успешно добавлен!", "", MessageBoxButton.OK);
                Manager.MainFrame.Navigate(new ReceptionEditPage());
            }
        }
    }
}