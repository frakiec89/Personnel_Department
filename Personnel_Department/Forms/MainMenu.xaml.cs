using System;
using System.Threading.Tasks;
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
            Application.Current.Dispatcher.Invoke(() =>
            {
                var userWindow = new UserWindow();
                 userWindow.Show();
            });
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

        private void BtSpecialty_Click(object sender, RoutedEventArgs e)
        {
            var window = new Forms.SpecialtyWindow();
            window.Show();
            Close();
        }

        private void BtSpecialty_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new Forms.SpecialtyInfoWindow();
            window.Show();
            Close();
        }
    }
}