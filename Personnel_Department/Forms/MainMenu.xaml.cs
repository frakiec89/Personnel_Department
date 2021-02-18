using System.Windows;

namespace Personnel_Department
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu() => InitializeComponent();

        private void BtUser_Click(object sender, RoutedEventArgs e)
        {
            UserWindow userWindow = new UserWindow();
            userWindow.Show();
            Close();
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
            Forms.DepartmentWindow window = new Forms.DepartmentWindow();
            window.Show();
            Close();
        }

        private void BtDeiraction_Click(object sender, RoutedEventArgs e)
        {
            Forms.DirectionWindow window = new Forms.DirectionWindow();
            window.Show();
            Close();
        }

        private void BtSpecialty_Click(object sender, RoutedEventArgs e)
        {
            Forms.SpecialtyWindow window = new Forms.SpecialtyWindow();
            window.Show();
            Close();
        }

        private void BtSpecialty_Click_1(object sender, RoutedEventArgs e)
        {
            Forms.SpecialtyInfoWindow window = new Forms.SpecialtyInfoWindow();
            window.Show();
            Close();
        }
    }
}