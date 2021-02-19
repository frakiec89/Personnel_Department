using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Personnel_Department.Forms.AdditionalForms
{
    /// <summary>
    /// Логика взаимодействия для AddSpeciallity.xaml
    /// </summary>
    public  partial class AddSpeciallity : Window
    {

        protected Specialty _specialty = new Specialty();

        public AddSpeciallity()
        {
            InitializeComponent();
            Loaded += AddSpeciallity_Loaded;
            btDell.Visibility = Visibility.Hidden;
        }

        protected  virtual async void AddSpeciallity_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Controllers.DiractionController controller =
                new Controllers.DiractionController();
                cbDir.ItemsSource = await Task.Run(() => controller.Directions);
                grids.DataContext = _specialty;
            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage(ex.Message);
            }
        }
        protected virtual void BtSave_Click(object sender, RoutedEventArgs e)
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

            Direction d = cbDir.SelectedItem as Direction;
            _specialty.DirectionId = d.DirectionId;

            try
            {
                Controllers.SpecialtyController cont = new Controllers.SpecialtyController(_specialty);
                cont.Add();
                MessageForms.MessageForms.MessageBoxMessage("Объект добавлен  в БД");
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage(ex.Message);
            }
        }

        protected virtual void btDell_Click(object sender, RoutedEventArgs e) { }
        
    }

    public  class CangeSpeciallty : AddSpeciallity
    {
        public CangeSpeciallty (Specialty specialty ):base()
        {
            base._specialty = specialty;
            btDell.Visibility = Visibility.Visible;
            
        }
        protected async override void AddSpeciallity_Loaded(object sender, RoutedEventArgs e)
        {
            base.Title = "Редактировать специальность";
            base.btSave.Content = "Сохранить изменения в БД";
            lbcode.Content = "Код";
            lbprim.Content = "";
            lbname.Content = "Название";
            try
            {
                Controllers.DiractionController controller =
                new Controllers.DiractionController();
                cbDir.ItemsSource = await Task.Run(() => controller.Directions);
                grids.DataContext = _specialty;
                cbDir.SelectedItem = (cbDir.ItemsSource as List<Direction>).Single(c => c.DirectionId == _specialty.DirectionId);
            }
            catch (Exception ex) { MessageForms.MessageForms.MessageBoxMessage(ex.Message); }
        }

       

        protected override void BtSave_Click(object sender, RoutedEventArgs e)
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
            Direction d = cbDir.SelectedItem as Direction;
            _specialty.Directions = d;
            _specialty.DirectionId = d.DirectionId;

            try
            {
                Controllers.SpecialtyController cont = new Controllers.SpecialtyController(_specialty);
                cont.Update();
                MessageForms.MessageForms.MessageBoxMessage("Объект обновлен  в БД");
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageForms.MessageForms.MessageBoxMessage(ex.Message);
            }
        }

        protected override void btDell_Click(object sender, RoutedEventArgs e)
        {
           if ( MessageForms.MessageForms.MessageBoxDell("Вы действительно хотите удалить  специальность?") == MessageBoxResult.Yes)
            {
                try
                {
                    Controllers.SpecialtyController cont = new Controllers.SpecialtyController(_specialty);
                    cont.Dell();
                    MessageForms.MessageForms.MessageBoxMessage("Объект удален из БД");
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
}
