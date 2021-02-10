using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personnel_Department
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {

        public UserWindow() => InitializeComponent();

        private void UserWindow_Loaded(object sender, RoutedEventArgs e) => UpdateDb();

        private async void UpdateDb()
        {
            var userController = await Task.Run(() => new Controllers.UserController(true));
            //TODO: ad
            LbMain.ItemsSource = userController.Refresh();
            lbTimeRun.Visibility = Visibility.Collapsed;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainMenu();
            window.Show();
            Close();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Forms.AdditionalUserWindow window = new Forms.AdditionalUserWindow(LbMain.SelectedItem);
            window.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new Forms.AdditionalUserWindow();
            window.ShowDialog();
            UpdateDb();
        }
    }
}
