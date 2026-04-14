using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace ShopApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string price = txtPrice.Text;

            if (name != "" && price != "")
            {
                listBox.Items.Add($"Товар: {name} | Ціна: {price} грн");

                txtName.Clear();
                txtPrice.Clear();
            }
            else
            {
                MessageBox.Show("Заповни всі поля!");
            }
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Обери товар для видалення!");
            }
        }
    }
}