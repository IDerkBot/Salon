using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AuthReg
{
    public partial class RegPage : Page
    {
        public RegPage() { InitializeComponent(); }

        void RegIn_Click(object sender, RoutedEventArgs e)
        {
            var users = dbsalonEntities.GetContext().Users.Where(x => x.Login == login.Text).ToList();
            if (login.Text == "" || password.Text == "")
                MessageBox.Show("Заполните все поля.", "", MessageBoxButton.OK);
            else
            {
                if (users.Count == 1) MessageBox.Show("Такой пользователь уже существует!", "", MessageBoxButton.OK);
                else
                {
                    User user = new User { Login = login.Text, Password = password.Text };
                    dbsalonEntities.GetContext().Users.Add(user);
                    dbsalonEntities.GetContext().SaveChanges();
                    MessageBox.Show("Вы успешно зарегистрировались.", "", MessageBoxButton.OK);
                    Manager.MainFrame.Navigate(new AuthPage());
                }
            }
        }
        void Cancel_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AuthPage()); }
    }
}