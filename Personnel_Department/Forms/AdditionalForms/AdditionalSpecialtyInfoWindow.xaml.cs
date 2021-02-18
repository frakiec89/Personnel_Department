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
    /// Просмотр
    /// </summary>
    public partial class AdditionalSpecialtyInfoWindow : Window
    {
        private SpecialtyInformation Specialyty { get; init; }
        public AdditionalSpecialtyInfoWindow() => InitializeComponent();
        public AdditionalSpecialtyInfoWindow(object SelectedSpecialtyObj): this()
        {
            lbNameCon.Visibility = Visibility.Visible;
            lbSpecialtyC.Visibility = Visibility.Visible;
            cbSpecialty.Visibility = Visibility.Collapsed;
            TbName.Visibility = Visibility.Collapsed;
            lbBaseNoBase.Visibility = Visibility.Visible;
            btEdit.Visibility = Visibility.Visible;
            cbFormOfEducation.Visibility = Visibility.Collapsed;
            TbTrainingPeriodM.Visibility = Visibility.Collapsed;
            TbTrainingPeriodY.Visibility = Visibility.Collapsed;
            rbBase.Visibility = Visibility.Collapsed;
            rbNoBase.Visibility = Visibility.Collapsed;
            Controllers.SpecialtyInfoController specialtyInfoController = new();
            Specialyty = (SpecialtyInformation)SelectedSpecialtyObj;
            grids.DataContext = Specialyty;
            lbSpecialtyC.Content = new Controllers.SpecialtyController().Specialties.Find(x => x.SpecialtyId == Specialyty.SpecialtyId);}

        protected virtual void BtSave_Click(object sender, RoutedEventArgs e) { }

        private void BtEdit_Click(object sender, RoutedEventArgs e)
        {
            var window = new AdditionalSpecialtyInfoEditWindow(Specialyty);
            window.Show();
        }
    }

    /// <summary>
    /// Редактирование
    /// </summary>
    public class AdditionalSpecialtyInfoEditWindow: AdditionalSpecialtyInfoWindow
    {
        SpecialtyInformation specialyty;
        public AdditionalSpecialtyInfoEditWindow(object selectedSpecialtyObj) :base()
        {
            btSave.Visibility = Visibility.Visible;
            Controllers.SpecialtyInfoController specialtyInfoController = new();
            TbTrainingPeriodM.Visibility = Visibility.Collapsed;
            lbBaseNoBase.Visibility = Visibility.Collapsed;
            lbTrainingPeriodC.Visibility = Visibility.Collapsed;
            lbBaseNoBase.Visibility = Visibility.Collapsed;
            TbTrainingPeriodM.Visibility = Visibility.Visible;
            TbTrainingPeriodY.Visibility = Visibility.Visible;
            lbTrainingPeriodC.Visibility = Visibility.Collapsed;
            
            specialyty = (SpecialtyInformation)selectedSpecialtyObj;
            var selectedSpecialyty = specialtyInfoController.SpecialtyInformation.Find(x => x.SpecialtyinformationId == specialyty.SpecialtyinformationId);
            TbTrainingPeriodY.Text = specialyty.TrainingPeriod.Year.ToString();
            TbTrainingPeriodM.Text = specialyty.TrainingPeriod.Month.ToString();

            grids.DataContext = selectedSpecialyty;
            cbFormOfEducation.ItemsSource = new Controllers.FormOfEducationController().FormOfEducations.ToList();
            cbFormOfEducation.SelectedItem = ((List<FormOfEducation>)cbFormOfEducation.ItemsSource).Find(x => x.FormOfEducationId == specialyty.FormOfEducationId);
            cbSpecialty.ItemsSource = new Controllers.SpecialtyController().Specialties.ToList();
            cbSpecialty.SelectedItem = ((List<Specialty>)cbSpecialty.ItemsSource).Find(x => x.SpecialtyId == specialyty.SpecialtyId);
           
            if (selectedSpecialyty.BaseEndNoBase == rbNoBase.Content.ToString())
                rbNoBase.IsChecked = true;
            else
                rbBase.IsChecked = true;
        }

        protected override void BtSave_Click(object sender, RoutedEventArgs e)
        {
            string baseEndNoBase = null;
            if ((bool)rbBase.IsChecked)
                baseEndNoBase = (string)rbBase.Content;

            else if ((bool)rbNoBase.IsChecked)
                baseEndNoBase = (string)rbNoBase.Content;

            try
            {
                specialyty = (SpecialtyInformation)grids.DataContext;
                specialyty.BaseEndNoBase = baseEndNoBase;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show(Controllers.SpecialtyInfoController.UpdateSpecialtyInfo(specialyty));
            Close();
        }
    }

    /// <summary>
    /// Создание
    /// </summary>
    public class AdditionalSpecialtyInfoCreateWindow : AdditionalSpecialtyInfoWindow
    {
        public AdditionalSpecialtyInfoCreateWindow():base()
        {
            Controllers.SpecialtyInfoController specialtyInfoController = new();
            TbTrainingPeriodM.Visibility = Visibility.Collapsed;
            cbFormOfEducation.ItemsSource = specialtyInfoController.SpecialtyInformation.ToList();
            cbSpecialty.ItemsSource = specialtyInfoController.SpecialtyInformation.ToList();
        }
        protected override void BtSave_Click(object sender, RoutedEventArgs e)
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
            MessageBox.Show(Controllers.SpecialtyInfoController.CreateSpecialtyInfo(newSpecInfo));
            Close();
        }
    }
}
