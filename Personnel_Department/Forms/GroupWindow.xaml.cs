using System.Windows;
using System.Windows.Input;

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
