using System.Windows;
using System.Windows.Input;

namespace Personnel_Department.Forms
{
    /// <summary>
    /// Логика взаимодействия для SpecialtyInfoWindow.xaml
    /// </summary>
    public partial class SpecialtyInfoWindow : Window
    {
        public SpecialtyInfoWindow() => InitializeComponent();

        void UpdateDb() => LbMain.ItemsSource = new Controllers.SpecialtyInfoController().SpecialtyInformation;
        private void Window_Loaded(object sender, RoutedEventArgs e) => UpdateDb();

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainMenu();
            window.Show();
            Close();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var window = new AdditionalForms.AdditionalSpecialtyInfoCreateWindow();
            window.ShowDialog();
            UpdateDb();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var window = new AdditionalForms.AdditionalSpecialtyInfoWindow(LbMain.SelectedItem);
            window.ShowDialog();
            UpdateDb();
        }
    }
    
}
