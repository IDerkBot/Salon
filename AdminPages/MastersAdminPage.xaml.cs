using SalonApp.AdminEditPages;
using SalonApp.Menu;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminPages
{
    public partial class MastersAdminPage : Page
    {
        public MastersAdminPage()
        {
            InitializeComponent();
            DGMasterAdmin.ItemsSource = dbsalonEntities.GetContext().Masters.OrderBy(x => x.Id).Skip(1).ToList();
        }
        void BtnEdit_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new MasterEditPage((sender as Button).DataContext as Master)); }
        void BtnAdd_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new MasterEditPage(null)); }
        void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var masterForRemoving = DGMasterAdmin.SelectedItems.Cast<Master>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {masterForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dbsalonEntities.GetContext().Masters.RemoveRange(masterForRemoving);
                    dbsalonEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGMasterAdmin.ItemsSource = dbsalonEntities.GetContext().Masters.ToList();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message.ToString()); }
            }
        }
        void InMenu_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminMenu()); }
    }
}