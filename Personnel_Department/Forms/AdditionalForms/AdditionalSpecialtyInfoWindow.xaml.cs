using Personnel_Department.BL.ModelDataBase;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Personnel_Department.Forms.AdditionalForms
{
    /// <summary>
    /// Просмотр
    /// </summary>
    public partial class AdditionalSpecialtyInfoWindow : Window
    {
        SpecialtyInformation SelectedSpecialty { get; set; }
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
            SelectedSpecialty = (SpecialtyInformation)SelectedSpecialtyObj;
            grids.DataContext = SelectedSpecialty;
            lbSpecialtyC.Content = new Controllers.SpecialtyController().Specialties.Find(x => x.SpecialtyId == SelectedSpecialty.SpecialtyId);
        }

        protected virtual void BtSave_Click(object sender, RoutedEventArgs e) { }

        private void BtEdit_Click(object sender, RoutedEventArgs e)
        {
            var window = new AdditionalSpecialtyInfoEditWindow(SelectedSpecialty);
            window.Show();
            Close();
        }
    }

    /// <summary>
    /// Редактирование
    /// </summary>
    public sealed class AdditionalSpecialtyInfoEditWindow: AdditionalSpecialtyInfoWindow
    {
        SpecialtyInformation SelectedSpecialty { get; set; }
        public AdditionalSpecialtyInfoEditWindow(SpecialtyInformation SelectedSpecialty) :base()
        {
            this.SelectedSpecialty = SelectedSpecialty;
            btSave.Visibility = Visibility.Visible;
            Controllers.SpecialtyInfoController specialtyInfoController = new();
            TbTrainingPeriodM.Visibility = Visibility.Collapsed;
            lbBaseNoBase.Visibility = Visibility.Collapsed;
            lbTrainingPeriodC.Visibility = Visibility.Collapsed;
            lbBaseNoBase.Visibility = Visibility.Collapsed;
            TbTrainingPeriodM.Visibility = Visibility.Visible;
            TbTrainingPeriodY.Visibility = Visibility.Visible;
            lbTrainingPeriodC.Visibility = Visibility.Collapsed;
            TbTrainingPeriodY.Text = SelectedSpecialty.TrainingPeriod.Year.ToString();
            TbTrainingPeriodM.Text = SelectedSpecialty.TrainingPeriod.Month.ToString();
            grids.DataContext = SelectedSpecialty;
            cbFormOfEducation.ItemsSource = new Controllers.FormOfEducationController().FormOfEducations.ToList();
            cbFormOfEducation.SelectedItem = ((List<FormOfEducation>)cbFormOfEducation.ItemsSource).Find(x => x.FormOfEducationId == SelectedSpecialty.FormOfEducationId);
            cbSpecialty.ItemsSource = new Controllers.SpecialtyController().Specialties.ToList();
            cbSpecialty.SelectedItem = ((List<Specialty>)cbSpecialty.ItemsSource).Find(x => x.SpecialtyId == SelectedSpecialty.SpecialtyId);
           
            if (SelectedSpecialty.BaseEndNoBase == rbNoBase.Content.ToString())
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
                SelectedSpecialty = (SpecialtyInformation)grids.DataContext;
                SelectedSpecialty.BaseEndNoBase = baseEndNoBase;
                SelectedSpecialty.FormOfEducationId =((FormOfEducation)cbFormOfEducation.SelectedItem).FormOfEducationId;
                SelectedSpecialty.SpecialtyId = ((Specialty)cbSpecialty.SelectedItem).SpecialtyId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
                MessageBox.Show(Controllers.SpecialtyInfoController.CreateOrUpdateSpecialtyInformation(SelectedSpecialty));
            Close();
        }
    }

    /// <summary>
    /// Создание
    /// </summary>
    public sealed class AdditionalSpecialtyInfoCreateWindow : AdditionalSpecialtyInfoWindow
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
            MessageBox.Show(Controllers.SpecialtyInfoController.CreateOrUpdateSpecialtyInformation(newSpecInfo));
            Close();
        }
    }
}
