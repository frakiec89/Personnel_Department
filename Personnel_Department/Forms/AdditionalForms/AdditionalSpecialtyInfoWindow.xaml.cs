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
    /// Логика взаимодействия для AdditionalSpecialtyInfoWindow.xaml
    /// </summary>
    public partial class AdditionalSpecialtyInfoWindow : Window
    {
        public AdditionalSpecialtyInfoWindow()
        {
            InitializeComponent();
            btSave.Visibility = Visibility.Visible;
            cbSpecialty.ItemsSource = new Controllers.SpecialtyController().Specialties;
            cbFormOfEducation.ItemsSource = new Controllers.FormOfEducationController().FormOfEducations;
        }
        public AdditionalSpecialtyInfoWindow(object SelectedSpecialtyObj)
        {
            InitializeComponent();
            Controllers.SpecialtyInfoController specialtyInfoController = new();
            TbTrainingPeriodM.Visibility = Visibility.Collapsed;
            var specialyty = (SpecialtyInformation)SelectedSpecialtyObj;
            var selectedSpecialyty = specialtyInfoController.SpecialtyInformation.Find(x => x.SpecialtyinformationId == specialyty.SpecialtyinformationId);
            grids.DataContext = selectedSpecialyty;
            cbFormOfEducation.SelectedItem = specialtyInfoController.SpecialtyInformation.Single(x => x.FormOfEducationId == selectedSpecialyty.FormOfEducationId);
            cbSpecialty.SelectedItem = specialtyInfoController.SpecialtyInformation.Single(x => x.SpecialtyId == selectedSpecialyty.SpecialtyId);
            if (selectedSpecialyty.BaseEndNoBase == rbNoBase.Content.ToString())
                rbNoBase.IsChecked = true;
            else
                rbBase.IsChecked = true;

        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            string baseEndNoBase = null;
            if ((bool)rbBase.IsChecked)
                baseEndNoBase = (string)rbBase.Content;

            else if ((bool)rbNoBase.IsChecked)
                baseEndNoBase = (string)rbNoBase.Content;

            SpecialtyInformation newSpecInfo;
            try
            {
                newSpecInfo = new SpecialtyInformation
                    (
                        ((Specialty)cbSpecialty.SelectedItem).SpecialtyId,
                        TbName.Text,
                        baseEndNoBase,
                        ((FormOfEducation)cbFormOfEducation.SelectedItem).FormOfEducationId,
                        TbTrainingPeriodY.Text, TbTrainingPeriodM.Text
                     );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show(Controllers.SpecialtyInfoController.EditOrCreateUser(newSpecInfo));
            Close();
        }
    }
}
