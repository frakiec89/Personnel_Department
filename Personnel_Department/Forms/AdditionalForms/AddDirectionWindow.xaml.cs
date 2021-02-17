using Personnel_Department.BL.ModelDataBase;
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

namespace Personnel_Department.Forms.AdditionalForms
{
    /// <summary>
    /// Логика взаимодействия для AddDirectionWindow.xaml
    /// </summary>
    public partial class AddDirectionWindow : Window
    {
        public AddDirectionWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Сохраняем  направление  в  бд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Controllers.DiractionController controller = new Controllers.DiractionController(TbName.Text);
                controller.AddDiraction();
                MessageBox.Show("Объект сохранен в БД");
                DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    public class CangeDirectionWindow : AddDirectionWindow
    {
        private Direction DirectionCange;

       public CangeDirectionWindow (Direction direction): base ()
       {
            base.Title = "Редактирование";
            btSave.Content = "Изменить";
            DirectionCange = direction;
            grids.DataContext = DirectionCange;
       }

        protected override void btSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DirectionCange = grids.DataContext as Direction;
                Controllers.DiractionController controller = new Controllers.DiractionController(DirectionCange);
                controller.UpdateDiraction();
                MessageForms.MessageForms.MessageBoxMessage("Объект изменен в БД");
                DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage(ex.Message);
            }
        }


    }
}
