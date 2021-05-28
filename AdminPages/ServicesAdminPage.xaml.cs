using SalonApp.AdminEditPages;
using SalonApp.Menu;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminPages
{
    public partial class ServicesAdminPage : Page
    {
        public ServicesAdminPage()
        {
            InitializeComponent();
            DGServicesAdmin.ItemsSource = dbsalonEntities.GetContext().Services.OrderBy(x => x.Id).Skip(1).ToList();
        }

        void BtnEdit_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ServiceEditPage((sender as Button).DataContext as Service)); }

        void BtnAdd_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ServiceEditPage()); }

        void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var departmentsForRemoving = DGServicesAdmin.SelectedItems.Cast<Service>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {departmentsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dbsalonEntities.GetContext().Services.RemoveRange(departmentsForRemoving);
                    dbsalonEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGServicesAdmin.ItemsSource = dbsalonEntities.GetContext().Services.OrderBy(x => x.Id).Skip(1).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        void InMenu_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminMenu()); }
    }
}