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
    /// Логика взаимодействия для AdditionalDepartmentWindow.xaml
    /// </summary>
    public partial class AdditionalDepartmentWindow : Window
    {
        public object Deparment { get; set; }
        public AdditionalDepartmentWindow(object selectedObjDeparment)
        {
            InitializeComponent();
            
            Deparment = selectedObjDeparment;
            grids.DataContext = Deparment;
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
