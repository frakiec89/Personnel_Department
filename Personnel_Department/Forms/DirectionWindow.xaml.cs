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
            if (MessageBoxResult.Yes == MessageForms.MessageForms.MessageBoxDell("Вы действительно хотите удалить направление?"))
            {
                try
                {
                    var b = e.OriginalSource as Button;
                    var d = b.DataContext as Direction;
                    Controllers.DiractionController.DellDiraction(d.DirectionId);
                    MessageForms.MessageForms.MessageBoxMessage("Удаление  прошло  успешно");
                    Controllers.DiractionController diractionController = new Controllers.DiractionController();
                    LbMain.ItemsSource = diractionController.Directions;
                }
                catch (Exception ex)
                {
                    MessageForms.MessageForms.MessageBoxMessage(ex.Message);   
                }
            }
        }

        private void btCange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var b = e.OriginalSource as Button;
                var d = b.DataContext as Direction;

                AddDirectionWindow window = new CangeDirectionWindow(d);
                if (window.ShowDialog() == true)
                {
                    Controllers.DiractionController diractionController = new Controllers.DiractionController();
                    LbMain.ItemsSource = diractionController.Directions;
                }
            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage(ex.Message);
            }
        }
    }
}
