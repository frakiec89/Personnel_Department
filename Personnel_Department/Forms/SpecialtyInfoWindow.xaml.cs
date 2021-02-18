using Personnel_Department.BL.ModelDataBase;
using Personnel_Department.Forms.AdditionalForms;

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

        private void UpdateDb() => lbMain.ItemsSource = new Controllers.SpecialtyInfoController().SpecialtyInformation;
        private void Window_Loaded(object sender, RoutedEventArgs e) => UpdateDb();

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            Close();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            AdditionalSpecialtyInfoCreateWindow window = new AdditionalForms.AdditionalSpecialtyInfoCreateWindow();
            window.ShowDialog();
            UpdateDb();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AdditionalSpecialtyInfoWindow window = new AdditionalForms.AdditionalSpecialtyInfoWindow((SpecialtyInformation)lbMain.SelectedItem);
            window.ShowDialog();
            UpdateDb();
        }
    }

}
