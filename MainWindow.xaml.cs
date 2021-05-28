using SalonApp.AuthReg;
using System.Windows;

namespace SalonApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthPage());
            Manager.MainFrame = MainFrame;
        }
    }
}