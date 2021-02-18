using Personnel_Department.Controllers;

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
    /// Логика взаимодействия для SpecialtyWindow.xaml
    /// </summary>
    public partial class SpecialtyWindow : Window
    {
        public SpecialtyWindow()
        {
            InitializeComponent();
         


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LbMain.ItemsSource = new SpecialtyController().Specialties;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainMenu();
            window.Show();
            Close();
        }

        /// <summary>
        /// Добавить специальность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Forms.AdditionalForms.AddSpeciallity add = new AdditionalForms.AddSpeciallity();
            if (add.ShowDialog() == true)
            {
                //todo обновить  контент 
            }
        }
    }
}
