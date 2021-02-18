using Personnel_Department.Controllers;

using System.Windows;

namespace Personnel_Department.Forms
{
    /// <summary>
    /// Логика взаимодействия для SpecialtyWindow.xaml
    /// </summary>
    public partial class SpecialtyWindow : Window
    {
        public SpecialtyWindow() => InitializeComponent();

        private void Window_Loaded(object sender, RoutedEventArgs e) => lbMain.ItemsSource = new SpecialtyController().Specialties;

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            Close();
        }

        /// <summary>
        /// Добавить специальность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateSpecialty_Click(object sender, RoutedEventArgs e)
        {
            Forms.AdditionalForms.AddSpeciallity add = new AdditionalForms.AddSpeciallity();
            if (add.ShowDialog() == true)
            {
                //ToDo обновить  контент 
            }
        }
    }
}