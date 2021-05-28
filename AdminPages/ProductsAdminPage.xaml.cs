using SalonApp.AdminEditPages;
using SalonApp.Menu;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminPages
{
    public partial class ProductsAdminPage : Page
    {
        public ProductsAdminPage()
        {
            InitializeComponent();
            DGProductsAdmin.ItemsSource = dbsalonEntities.GetContext().Products.ToList();
        }
        void BtnEdit_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ProductEditPage((sender as Button).DataContext as Product)); }
        void BtnAdd_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ProductEditPage()); }
        void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var treatmentsForRemoving = DGProductsAdmin.SelectedItems.Cast<Product>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {treatmentsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dbsalonEntities.GetContext().Products.RemoveRange(treatmentsForRemoving);
                    dbsalonEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGProductsAdmin.ItemsSource = dbsalonEntities.GetContext().Products.OrderBy(x => x.Id).Skip(1).ToList();
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