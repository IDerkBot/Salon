using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AdminEditPages
{
    public partial class ReceptionEditPage : Page
    {
        decimal _sum = 0;
        string _date = "";
        readonly List<string> time = new List<string>{
                "08:00","08:30","09:00","09:30", "10:00","10:30","11:00","11:30","12:00",
                "12:30","13:00","13:30", "14:00","14:30","15:00","15:30","16:00","16:30"
        };
        public ReceptionEditPage(Reception selectedReception = null)
        {
            InitializeComponent();
            MasterCB.ItemsSource = dbsalonEntities.GetContext().Masters.Select(x => x.Name).ToList();
            ClientCB.ItemsSource = dbsalonEntities.GetContext().Clients.Select(x => x.Name).ToList();
            Time.ItemsSource = time;
            ServiceCB.ItemsSource = dbsalonEntities.GetContext().Services.Select(x => x.Name).ToList();
            ProductCB.ItemsSource = dbsalonEntities.GetContext().Products.Select(x => x.Name).ToList();
        }
        void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (MasterCB.SelectedItem == null || ClientCB.SelectedItem == null || (ServiceCB.SelectedItem == null && ProductCB.SelectedItem == null) || Date.SelectedDate == null || Time.SelectedItem == null)
                MessageBox.Show("Выберите все поля под звездочкой!", "", MessageBoxButton.OK);
            else
            {
                var _clients = dbsalonEntities.GetContext().Clients.Where(x => x.Name == ClientCB.SelectedItem.ToString()).ToList();
                int _client;
                if (_clients.Count() == 1) _client = _clients.Select(x => x.Id).FirstOrDefault();
                else
                {
                    var client = new Client
                    {
                        Name = ClientCB.SelectedItem.ToString(),
                        IdUser = DataBank.UserID
                    };
                    dbsalonEntities.GetContext().Clients.Add(client);
                    dbsalonEntities.GetContext().SaveChanges();
                    _client = dbsalonEntities.GetContext().Clients.Where(x => x.Name == ClientCB.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault();
                }
                var _master = dbsalonEntities.GetContext().Masters.Where(x => x.Name == MasterCB.SelectedItem.ToString()).Select(i => i.Id).FirstOrDefault();
                Reception reception = new Reception
                {
                    IdClient = _client,
                    IdMaster = _master,
                    Date = _date,
                    Time = Time.SelectedItem.ToString(),
                    IdService = (ServiceCB.SelectedItem == null) ? 1 : dbsalonEntities.GetContext().Services.Where(x => x.Name == ServiceCB.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault(),
                    IdProduct = (ProductCB.SelectedItem == null) ? 1 : dbsalonEntities.GetContext().Products.Where(x => x.Name == ProductCB.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault(),
                    Sum = _sum
                };
                dbsalonEntities.GetContext().Receptions.Add(reception);
                dbsalonEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись на прием оформлена", "", MessageBoxButton.OK);
                Manager.MainFrame.Navigate(new UserPages.ReceptionsPage());
            }
        }
        void AddClient_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new ClientAddPage()); }
        void ServiceCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { ChangeTime(); }
        void ProductCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { ChangeTime(); }
        void Date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        { ChangeTime(); }
        void ChangeTime()
        {
            var selectMaster = (MasterCB.SelectedItem == null) ? "" : MasterCB.SelectedItem.ToString();
            if (selectMaster != "")
            {
                var idMaster = dbsalonEntities.GetContext().Masters.Where(x => x.Name == selectMaster).Select(x => x.Id).Single();
                _date = $"{Date.SelectedDate}";
                if (_date.Contains("/"))
                {
                    var dateSplitSpace = _date.Split(' ');
                    var dateSplitSlash = $"{dateSplitSpace[0]}".Split('/');
                    _date = $"{dateSplitSlash[1]}.{dateSplitSlash[0]}.{dateSplitSlash[2]}";
                }
                var useTime = dbsalonEntities.GetContext().Receptions.Where(x => x.IdMaster == idMaster && x.Date == _date).Select(x => x.Time).ToList();
                var newTime = time.Except(useTime);
                Time.ItemsSource = newTime;
            }
        }

        void InReception_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminPages.ReceptionsAdminPage()); }
    }
}