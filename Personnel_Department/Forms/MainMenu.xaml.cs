using System.Windows;

namespace Personnel_Department
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtUser_Click(object sender, RoutedEventArgs e)
        {
            var userWindow = new UserWindow();
            userWindow.Show();
            Hide();
        }

        private void BtStudent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void BtCurators_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void BtDeparments_Click(object sender, RoutedEventArgs e)
        {
            var window = new Forms.DepartmentWindow();
            window.Show();
            Close();
        }

        private void BtDeiraction_Click(object sender, RoutedEventArgs e)
        {
            var window = new Forms.DirectionWindow();
            window.Show();
            Close();
        }
    }
}