using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.UserEditPages
{
    public partial class AddReception : Page
    {
        decimal _sum = 0;
        string _date = "";
        int _discount = 0;
        readonly List<string> time = new List<string>{
                "08:00","08:30","09:00","09:30", "10:00","10:30","11:00","11:30","12:00",
                "12:30","13:00","13:30", "14:00","14:30","15:00","15:30","16:00","16:30"
        };
        public AddReception()
        {
            InitializeComponent();
            MasterCB.ItemsSource = dbsalonEntities.GetContext().Masters.Select(x => x.Name).ToList();
            Client.Text = dbsalonEntities.GetContext().Clients.Where(x => x.IdUser == DataBank.UserID).Select(y => y.Name).FirstOrDefault();
            Time.ItemsSource = time;
            ServiceCB.ItemsSource = dbsalonEntities.GetContext().Services.Select(x => x.Name).ToList();
            ProductCB.ItemsSource = dbsalonEntities.GetContext().Products.Select(x => x.Name).ToList();
        }
        void MasterCB_SelectionChanged(object sender, SelectionChangedEventArgs e) { ChangeTime(); }
        void Date_SelectedDateChanged(object sender, SelectionChangedEventArgs e) { ChangeTime(); }
        void ChangeTime()
        {
            var selectMaster = (MasterCB.SelectedItem == null) ? "" : MasterCB.SelectedItem.ToString();
            if(selectMaster != "")
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
        void ServiceCB_SelectionChanged(object sender, SelectionChangedEventArgs e) { ChangeSum(); }
        void ProductCB_SelectionChanged(object sender, SelectionChangedEventArgs e) { ChangeSum(); }
        void InReception_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserPages.ReceptionsPage()); }
        void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (MasterCB.SelectedItem == null || Client.Text == null || (ServiceCB.SelectedItem == null && ProductCB.SelectedItem == null) || Date.SelectedDate == null || Time.SelectedItem == null)
                MessageBox.Show("Выберите все поля под звездочкой!", "", MessageBoxButton.OK);
            else
            {
                var _clients = dbsalonEntities.GetContext().Clients.Where(x => x.Name == Client.Text).ToList();
                int _client;
                if (_clients.Count() == 1) _client = _clients.Select(x => x.Id).FirstOrDefault();
                else
                {
                    var client = new Client
                    {
                        Name = Client.Text,
                        IdUser = DataBank.UserID
                    };
                    dbsalonEntities.GetContext().Clients.Add(client);
                    dbsalonEntities.GetContext().SaveChanges();
                    _client = dbsalonEntities.GetContext().Clients.Where(x => x.Name == Client.Text).Select(x => x.Id).FirstOrDefault();
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
        void ChangeSum()
        {
            var _service = (ServiceCB.SelectedItem != null) ? ServiceCB.SelectedItem.ToString() : "null";
            var _product = (ProductCB.SelectedItem != null) ? ProductCB.SelectedItem.ToString() : "null";
            var _serviceCost = (_service == null) ? 0 : (int)dbsalonEntities.GetContext().Services.Where(x => x.Name == _service).Select(x => x.Price).FirstOrDefault();
            var _productCost = (_product == null) ? 0 : (int)dbsalonEntities.GetContext().Products.Where(x => x.Name == _product).Select(x => x.Price).FirstOrDefault();
            if (dbsalonEntities.GetContext().Receptions.Where(x => x.IdClient == DataBank.UserID).Count() >= 4) _discount = 5;
            _sum = (_serviceCost + _productCost) - ((_serviceCost + _productCost) * (_discount / 100));
            Discount.Text = $"{_discount}%";
            SumL.Text = $"{_sum} Рублей";
        }
    }
}