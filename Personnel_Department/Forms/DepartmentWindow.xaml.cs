﻿using System;
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
    /// Логика взаимодействия для DepartmentWindow.xaml
    /// </summary>
    public partial class DepartmentWindow : Window
    {
        public DepartmentWindow() => InitializeComponent();
        private void UpdateDb()
        {
            var controller = new Controllers.DepartmentController();
            LbMain.ItemsSource = (System.Collections.IEnumerable)controller.department;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) => UpdateDb();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainMenu();
            window.Show();
            Close();
        }
        public object MyProperty { get; set; }
        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MyProperty = LbMain.SelectedItem;
            var window = new AdditionalForms.AdditionalDepartmentWindow(MyProperty);
            window.Show();
            UpdateDb();
        }
    }
}
