using Personnel_Department.BL.ModelDataBase;
using Personnel_Department.Controllers;
using Personnel_Department.Forms.AdditionalForms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        private async void CreateSpecialty_Click(object sender, RoutedEventArgs e)
        {
            Forms.AdditionalForms.AddSpeciallity add = new AddSpeciallity();
            if (add.ShowDialog() == true)
            {
                try { lbMain.ItemsSource = await Task.Run(() => new SpecialtyController().Specialties); }
                catch (Exception ex) { MessageForms.MessageForms.MessageBoxMessage(ex.Message); }
            }
        }

        private async void lbMain_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                var s = sender as System.Windows.Controls.ListBox;
                Forms.AdditionalForms.CangeSpeciallty speciallity = new CangeSpeciallty(s.SelectedItem as Specialty);
                if ( speciallity.ShowDialog() == true)
                {
                    lbMain.ItemsSource = await Task.Run(() => new SpecialtyController().Specialties); 
                }
            }
            catch (Exception ex) { MessageForms.MessageForms.MessageBoxMessage(ex.Message); }
          
        }
    }
}