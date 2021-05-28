using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminEditPages
{
    public partial class ProductEditPage : Page
    {
        Product _currentProduct = new Product();
        public ProductEditPage(Product selectProduct = null)
        {
            InitializeComponent();
            if (selectProduct != null) _currentProduct = selectProduct;
            DataContext = _currentProduct;
        }

        void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentProduct.Name)) errors.AppendLine("Укажите информацию о лечении");
            if (errors.Length > 0) { MessageBox.Show(errors.ToString()); return; }
            if (_currentProduct.Id == 0) dbsalonEntities.GetContext().Products.Add(_currentProduct);
            try
            {
                dbsalonEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.Navigate(new AdminPages.ProductsAdminPage());
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}