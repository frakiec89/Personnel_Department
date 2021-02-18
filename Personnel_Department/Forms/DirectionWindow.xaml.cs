using Personnel_Department.BL.ModelDataBase;
using Personnel_Department.Forms.AdditionalForms;

using System;
using System.Windows;
using System.Windows.Controls;

namespace Personnel_Department.Forms
{
    /// <summary>
    /// Логика взаимодействия для DirectionWindow.xaml
    /// </summary>
    public partial class DirectionWindow : Window
    {
        public DirectionWindow() => InitializeComponent();

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.DiractionController diractionController = new Controllers.DiractionController();
            lbMain.ItemsSource = diractionController.Directions;
        }

        /// <summary>
        /// Добавить новое направление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAdditionalWindow_Click(object sender, RoutedEventArgs e)
        {
            AdditionalForms.AddDirectionWindow window = new AdditionalForms.AddDirectionWindow();
            if (window.ShowDialog() == true)
            {
                Controllers.DiractionController diractionController = new Controllers.DiractionController();
                lbMain.ItemsSource = diractionController.Directions;
            }
        }

        private void BtDell_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageForms.MessageForms.MessageBoxDell("Вы действительно хотите удалить направление?"))
            {
                try
                {
                    Button b = e.OriginalSource as Button;
                    Direction d = b.DataContext as Direction;
                    Controllers.DiractionController.DellDiraction(d.DirectionId);
                    MessageForms.MessageForms.MessageBoxMessage("Удаление  прошло  успешно");
                    Controllers.DiractionController diractionController = new Controllers.DiractionController();
                    lbMain.ItemsSource = diractionController.Directions;
                }
                catch (Exception ex)
                {
                    MessageForms.MessageForms.MessageBoxMessage(ex.Message);
                }
            }
        }

        private void BtCange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button b = e.OriginalSource as Button;
                Direction d = b.DataContext as Direction;

                AddDirectionWindow window = new EditDirectionWindow(d);
                if (window.ShowDialog() == true)
                {
                    Controllers.DiractionController diractionController = new Controllers.DiractionController();
                    lbMain.ItemsSource = diractionController.Directions;
                }
            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage(ex.Message);
            }
        }
    }
}
