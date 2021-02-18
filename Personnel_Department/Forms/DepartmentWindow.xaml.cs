using System.Windows;
using System.Windows.Input;

namespace Personnel_Department.Forms
{
    /// <summary>
    /// Логика взаимодействия для DepartmentWindow.xaml
    /// </summary>
    public partial class DepartmentWindow : Window
    {
        public DepartmentWindow() => InitializeComponent();
        private void UpdateDb()
        {
            Controllers.DepartmentController controller = new Controllers.DepartmentController();
            lbMain.ItemsSource = controller.Departments;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) => UpdateDb();

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            Close();
        }
        public object MyProperty { get; set; }
        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MyProperty = lbMain.SelectedItem;
            AdditionalForms.AdditionalDepartmentWindow window = new AdditionalForms.AdditionalDepartmentWindow(MyProperty);
            window.Show();
            UpdateDb();
        }
    }
}
