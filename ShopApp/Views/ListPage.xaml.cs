using System.Windows.Controls;

namespace ShopApp.Views
{
    public partial class ListPage : Page
    {
        public ListPage(string message)
        {
            InitializeComponent();
            MessageText.Text = message;
        }
    }
}
