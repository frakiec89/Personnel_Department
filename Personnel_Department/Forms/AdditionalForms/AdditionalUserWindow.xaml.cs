using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections;
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
    /// Логика взаимодействия для AdditionalUserWindow.xaml
    /// </summary>
    public partial class AdditionalUserWindow  : Window
    {
        /// <summary>
        /// Редактирование пользователей
        /// </summary>
        /// <param name="selectedObjUser"></param>
        public AdditionalUserWindow(object selectedObjUser)
        {
            InitializeComponent();
            var user = (User)selectedObjUser;
            Controllers.UserController userController = new Controllers.UserController();
            var selectedUser = userController.Users.Find(x => x.UserId == user.UserId);
            grids.DataContext = selectedUser;
        }


        public AdditionalUserWindow()
        {
            InitializeComponent();
            LbDateOfDismissal.Visibility =  Visibility.Hidden;
            btSave.Visibility = Visibility.Visible;
            DpDateOfDismissal.Visibility = Visibility.Hidden;
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User() { Name = TbName.Text, Surname = TbSurname.Text, Patronumic = TbPatronumic.Text, DateRegistrations = DpDateRegistrations.SelectedDate};
            MessageBox.Show(Controllers.UserController.CreateUser(newUser));
            Close();
        }
    }
}
