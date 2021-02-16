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
        private void btSave_Click(object sender, RoutedEventArgs e)
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
}
