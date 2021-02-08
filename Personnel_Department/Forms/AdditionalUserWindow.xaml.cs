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
    public partial class AdditionalUserWindow : Window
    {
        /// <summary>
        /// Редактирование пользователей
        /// </summary>
        /// <param name="selectedObjUser"></param>
        public AdditionalUserWindow(object selectedObjUser)
        {
            InitializeComponent();
            LbFirst.Content = "Фамилия";
            LbSecond.Content = "Имя";
            LbT.Content = "Отчество";
            LbFourth.Content = "Дата принятия на работу";
            LbFifth.Content = "Дата увольнения";
            var user = (User)selectedObjUser;
            Controllers.UserController userController = new Controllers.UserController();
            var selectedUser = userController.users.Find(x => x.UserId == user.UserId);
            grids.DataContext = selectedUser;
        }
        //public AdditionalUserWindow()
    }
}
