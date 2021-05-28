using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminEditPages
{
    public partial class ClientEditPage : Page
    {
        Client _currentClient = new Client();
        public ClientEditPage(Client selectedClient)
        {
            InitializeComponent();
            if (selectedClient != null) _currentClient = selectedClient;
            DataContext = _currentClient;
        }
        void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentClient.Id == 0) dbsalonEntities.GetContext().Clients.Add(_currentClient);
            try
            {
                dbsalonEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.Navigate(new AdminPages.ClientsAdminPage());
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}