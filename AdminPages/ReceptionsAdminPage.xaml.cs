using SalonApp.AdminEditPages;
using SalonApp.Menu;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminPages
{
    public partial class ReceptionsAdminPage : Page
    {
        public ReceptionsAdminPage()
        {
            InitializeComponent();
            DGReceptionAdmin.ItemsSource = dbsalonEntities.GetContext().Receptions.ToList();
        }
        void BtnEdit_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ReceptionEditPage((sender as Button).DataContext as Reception)); }
        void BtnAdd_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ReceptionEditPage()); }
        void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var receptionsForRemoving = DGReceptionAdmin.SelectedItems.Cast<Reception>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {receptionsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dbsalonEntities.GetContext().Receptions.RemoveRange(receptionsForRemoving);
                    dbsalonEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGReceptionAdmin.ItemsSource = dbsalonEntities.GetContext().Receptions.ToList();
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