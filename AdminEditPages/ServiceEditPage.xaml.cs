using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminEditPages
{
    public partial class ServiceEditPage : Page
    {
        Service _currentService = new Service();
        public ServiceEditPage(Service selectedService = null)
        {
            InitializeComponent();
            if (selectedService != null) _currentService = selectedService;
            DataContext = _currentService;
        }
        void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentService.Name)) errors.AppendLine("Укажите название отделение");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentService.Id == 0) dbsalonEntities.GetContext().Services.Add(_currentService);
            try
            {
                dbsalonEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.Navigate(new AdminPages.ServicesAdminPage());
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}