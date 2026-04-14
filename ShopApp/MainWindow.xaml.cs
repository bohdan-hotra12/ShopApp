using System.Windows;
using System.Windows.Controls;

namespace ShopApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // ✔ ДОДАВАННЯ ТОВАРУ
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

        // ✔ ВИДАЛЕННЯ ТОВАРУ
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

        // ⭐ НОВЕ: Очистити все
        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
        }

        // ⭐ НОВЕ: Показати інформацію
        private void ShowInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Всього товарів: {listBox.Items.Count}");
        }

        // ⭐ НОВЕ: тест кнопки (для звіту)
        private void Test_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка працює ✔");

        }
        private void OpenAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog();
        }

        private void OpenHelp_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.ShowDialog();
        }
    }
}