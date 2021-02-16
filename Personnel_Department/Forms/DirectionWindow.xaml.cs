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
    }
}
