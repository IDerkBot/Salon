using SalonApp.Menu;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonApp.AuthReg
{
    public partial class AuthPage : Page
    {
        public AuthPage() { InitializeComponent(); }
        void LogIn_Click(object sender, RoutedEventArgs e)
        {
            var user = dbsalonEntities.GetContext().Users.Where(x => x.Login == login.Text && x.Password == password.Text).ToList();
            if (user.Count == 1)
            {
                var _id = user.Select(x => x.Id).FirstOrDefault();
                if (user.Select(x => x.Access).FirstOrDefault() == 1)
                {
                    DataBank.UserID = _id;
                    MessageBox.Show("Администратор вы успешно вошли!", "", MessageBoxButton.OK);
                    Manager.MainFrame.Navigate(new AdminMenu());
                }
                else
                {
                    DataBank.UserID = _id;
                    Manager.MainFrame.Navigate(new UserMenu());
                }
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль", "", MessageBoxButton.OK);
                password.Clear();
            }
        }
        void RegIn_Click(object sender, RoutedEventArgs e) { Manager.MainFrame.Navigate(new RegPage()); }
    }
}