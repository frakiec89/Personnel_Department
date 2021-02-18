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
    /// Логика взаимодействия для AddSpeciallity.xaml
    /// </summary>
    public partial class AddSpeciallity : Window
    {

        private Specialty _specialty = new Specialty();

        public AddSpeciallity()
        {
            InitializeComponent();
            this.Loaded += AddSpeciallity_Loaded;
        }

        private async void AddSpeciallity_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Controllers.DiractionController controller =
                new Controllers.DiractionController();
                cbDir.ItemsSource = await Task.Run (()=> controller.Directions);
                grids.DataContext = _specialty;

            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage(ex.Message);
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbDir.SelectedIndex < 0)
            {
                MessageForms.MessageForms.MessageBoxMessage("Укажите направление");
                cbDir.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TbName.Text))
            {
                MessageForms.MessageForms.MessageBoxMessage("Укажите название");
                TbName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbCode.Text))
            {
                MessageForms.MessageForms.MessageBoxMessage("Укажите код специальности");
                tbCode.Focus();
                return;
            }

             _specialty = grids.DataContext as Specialty;

            var d = cbDir.SelectedItem as Direction;
            _specialty.DirectionId = d.DirectionId;

            try
            {
                Controllers.SpecialtyController cont = new Controllers.SpecialtyController(_specialty);
                cont.AddOrUpdate();
                MessageForms.MessageForms.MessageBoxMessage("Объект добавлен  в БД");
                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage("Объект добавлен  в БД");
            }
        }
    }
}
