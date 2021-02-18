using System.Windows;

namespace Personnel_Department
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            Close();
        }
    }
}