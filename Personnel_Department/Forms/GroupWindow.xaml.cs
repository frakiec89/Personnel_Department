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

namespace Personnel_Department.Forms
{
    /// <summary>
    /// Логика взаимодействия для GroupWindow.xaml
    /// </summary>
    public partial class GroupWindow : Window
    {
        public GroupWindow()
        {
            InitializeComponent();
        }

        private void LbMainMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Open Additional Info");
        }

        private void LbMainMouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("e");
        }
        private void BtBackClick(object sender, MouseEventArgs e)
        {

        }
    }
}
