using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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
            Controllers.UserController userController = await Task.Run(() => new Controllers.UserController(true));
            lbMain.ItemsSource = userController.Users;
            lbTimeRun.Visibility = Visibility.Collapsed;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            Close();
        }

        private void OpenAdditionalWindow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Forms.AdditionalUserWindow window = new Forms.AdditionalUserEditWindow(lbMain.SelectedItem);
            window.ShowDialog();
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            Forms.AdditionalUserWindow window = new Forms.AdditionalUserWindow();
            window.ShowDialog();
            UpdateDb();
        }
    }
}
