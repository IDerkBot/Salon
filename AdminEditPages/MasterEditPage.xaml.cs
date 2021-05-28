using SalonApp.AdminPages;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminEditPages
{
    public partial class MasterEditPage : Page
    {
        Master _currentMaster = new Master();
        public MasterEditPage(Master selectedMaster)
        {
            InitializeComponent();
            if (selectedMaster != null) _currentMaster = selectedMaster;
            DataContext = _currentMaster;
        }

        void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentMaster.Name)) errors.AppendLine("Укажите имя мастера");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentMaster.Id == 0) dbsalonEntities.GetContext().Masters.Add(_currentMaster);
            try
            {
                dbsalonEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.Navigate(new MastersAdminPage());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}