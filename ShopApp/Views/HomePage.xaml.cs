using System.Windows;
using System.Windows.Controls;

namespace ShopApp.Views
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void GoToList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListPage("Привіт з HomePage"));
        }
    }
}
