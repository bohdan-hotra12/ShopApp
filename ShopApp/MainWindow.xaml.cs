using System.Windows;
using ShopApp.Views;

namespace ShopApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HomePage());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void List_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListPage("Перехід з меню"));
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SettingsPage());
        }

        private void OpenAbout_Click(object sender, RoutedEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void OpenHelp_Click(object sender, RoutedEventArgs e)
        {
            new HelpWindow().ShowDialog();
        }
    }
}
