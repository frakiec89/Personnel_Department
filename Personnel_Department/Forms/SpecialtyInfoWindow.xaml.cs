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
            //var window = new AdditionalForms.AdditionalSpecialtyInfoCreateWindow();
            //window.ShowDialog();
            //UpdateDb();
            Window window = new();
            window.Show();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var window = new AdditionalForms.AdditionalSpecialtyInfoWindow(LbMain.SelectedItem);
            window.ShowDialog();
            UpdateDb();
        }
    }
    
}
