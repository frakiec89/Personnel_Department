using System.Windows;

namespace Personnel_Department.Forms
{
    /// <summary>
    /// Логика взаимодействия для DirectionWindow.xaml
    /// </summary>
    public partial class DirectionWindow : Window
    {
        public DirectionWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainMenu();
            window.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.DiractionController diractionController = new Controllers.DiractionController();
            LbMain.ItemsSource = diractionController.Directions;
        }

        /// <summary>
        /// Добавить новое направление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdditionalForms.AddDirectionWindow window = new AdditionalForms.AddDirectionWindow();
            if ( window.ShowDialog() == true)
            {
                Controllers.DiractionController diractionController = new Controllers.DiractionController();
                LbMain.ItemsSource = diractionController.Directions;
            }
        }

        private void btDell_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btCange_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
