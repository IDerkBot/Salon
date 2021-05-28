using SalonApp.Menu;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.UserPages
{
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            var client = dbsalonEntities.GetContext().Clients.Where(x => x.IdUser == DataBank.UserID);
            Name.Text = client.Select(x => x.Name).Single();
            Date.Text = client.Select(x => x.YearOfBirth).Single().ToString();
            Address.Text = client.Select(x => x.Address).Single();
            var _gender = client.Select(x => x.Gender).Single();
            if (_gender == "мужской" || _gender == "Мужской") GenderMan.IsChecked = true;
            if (_gender == "женский" || _gender == "Женский") GenderWoman.IsChecked = true;
        }
        void Save_Click(object sender, RoutedEventArgs e)
        {
            var client = dbsalonEntities.GetContext().Clients.Where(x => x.IdUser == DataBank.UserID).Single();
            client.Name = Name.Text;
            client.Name = Name.Text;
            client.YearOfBirth = Date.Text;
            client.Address = Address.Text;
            var _gender = ((bool)GenderMan.IsChecked) ? GenderMan.Content : (((bool)GenderWoman.IsChecked) ? GenderWoman.Content : "");
            client.Gender = _gender.ToString();
            client.IdUser = DataBank.UserID;
            dbsalonEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные успешно сохранены!", "", MessageBoxButton.OK);
            Manager.MainFrame.Navigate(new UserMenu());
        }
        void InMenu_Click(object sender, RoutedEventArgs e) { Manager.MainFrame.Navigate(new UserMenu()); }
    }
}