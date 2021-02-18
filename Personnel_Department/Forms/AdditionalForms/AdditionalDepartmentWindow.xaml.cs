using System.Windows;

namespace Personnel_Department.Forms.AdditionalForms
{
    /// <summary>
    /// Логика взаимодействия для AdditionalDepartmentWindow.xaml
    /// </summary>
    public partial class AdditionalDepartmentWindow : Window
    {
        public object Deparment { get; init; }
        public AdditionalDepartmentWindow(object selectedObjDeparment)
        {
            InitializeComponent();
            Deparment = selectedObjDeparment;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) => grids.DataContext = Deparment;


        private void BtSave_Click(object sender, RoutedEventArgs e)
        { 

        }

    }
}
