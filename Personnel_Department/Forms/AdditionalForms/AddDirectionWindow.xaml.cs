using Personnel_Department.BL.ModelDataBase;

using System;
using System.Windows;

namespace Personnel_Department.Forms.AdditionalForms
{
    /// <summary>
    /// Логика взаимодействия для AddDirectionWindow.xaml
    /// </summary>
    public partial class AddDirectionWindow : Window
    {
        public AddDirectionWindow() => InitializeComponent();

        /// <summary>
        /// Сохраняем  направление  в  бд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void BtSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Controllers.DiractionController controller = new Controllers.DiractionController(TbName.Text);
                controller.AddDiraction();
                MessageBox.Show("Объект сохранен в БД");
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class EditDirectionWindow : AddDirectionWindow
    {
        private Direction DirectionEdit;

        public EditDirectionWindow(Direction direction) : base()
        {
            base.Title = "Редактирование";
            btSave.Content = "Изменить";
            DirectionEdit = direction;
            grids.DataContext = DirectionEdit;
        }

        protected override void BtSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DirectionEdit = grids.DataContext as Direction;
                Controllers.DiractionController controller = new Controllers.DiractionController(DirectionEdit);
                controller.UpdateDiraction();
                MessageForms.MessageForms.MessageBoxMessage("Объект изменен в БД");
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage(ex.Message);
            }
        }
    }
}