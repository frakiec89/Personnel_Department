using Personnel_Department.BL.ModelDataBase;

using System.Windows;

namespace Personnel_Department.Forms
{
    /// <summary>
    /// Логика взаимодействия для AdditionalUserWindow.xaml
    /// </summary>
    public partial class AdditionalUserWindow : Window
    {
        public AdditionalUserWindow()
        {
            InitializeComponent();
            Title = "Регистрация пользователя";
            lbDateOfDismissal.Visibility = Visibility.Hidden;
            btSave.Visibility = Visibility.Visible;
            dpDateOfDismissal.Visibility = Visibility.Hidden;
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User() { Name = tbName.Text, Surname = tbSurname.Text, Patronumic = tbPatronumic.Text, DateRegistrations = dpDateRegistrations.SelectedDate };
            MessageBox.Show(Controllers.UserController.CreateOrEditUser(newUser));
            Close();
        }

        protected virtual void Window_Loaded(object sender, RoutedEventArgs e) { }
    }
    public class AdditionalUserEditWindow : AdditionalUserWindow
    {
        private User SelectedUser { get; init; }
        public AdditionalUserEditWindow(object selectedObjUser)
        {
            InitializeComponent();
            SelectedUser = (User)selectedObjUser;
            Title =$"Информация о пользователе + {SelectedUser.FullName}";
        }

        protected override void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.UserController userController = new Controllers.UserController();
            User selectedUser = userController.Users.Find(x => x.UserId == SelectedUser.UserId);
            grids.DataContext = selectedUser;
        }
    }
}
