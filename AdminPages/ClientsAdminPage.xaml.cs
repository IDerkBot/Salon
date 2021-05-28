using SalonApp.AdminEditPages;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminPages
{
    public partial class ClientsAdminPage : Page
    {
        public ClientsAdminPage()
        {
            InitializeComponent();
            DGClientAdmin.ItemsSource = dbsalonEntities.GetContext().Clients.ToList();
        }
        void BtnEdit_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ClientEditPage((sender as Button).DataContext as Client)); }
        void BtnAdd_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ClientEditPage(null)); }
        void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var ClientForRemoving = DGClientAdmin.SelectedItems.Cast<Client>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {ClientForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dbsalonEntities.GetContext().Clients.RemoveRange(ClientForRemoving);
                    dbsalonEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGClientAdmin.ItemsSource = dbsalonEntities.GetContext().Clients.ToList();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message.ToString()); }
            }
        }
        void InMenu_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new Menu.AdminMenu()); }
    }
}