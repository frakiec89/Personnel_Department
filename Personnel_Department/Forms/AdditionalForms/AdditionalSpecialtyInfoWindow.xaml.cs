using Personnel_Department.BL.ModelDataBase;
using Personnel_Department.Controllers;
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
        private SpecialtyInformation SelectedSpecialty { get; init; }
        public AdditionalSpecialtyInfoWindow() => InitializeComponent();
        public AdditionalSpecialtyInfoWindow(SpecialtyInformation selectedSpecialty) : this()
        {
            SelectedSpecialty = selectedSpecialty;
            #region Настройка интерфейса
            lbNameCon.Visibility = Visibility.Visible;
            lbSpecialtyC.Visibility = Visibility.Visible;
            cbSpecialty.Visibility = Visibility.Collapsed;
            tbName.Visibility = Visibility.Collapsed;
            lbBaseNoBase.Visibility = Visibility.Visible;
            btEdit.Visibility = Visibility.Visible;
            cbFormOfEducation.Visibility = Visibility.Collapsed;
            tbTrainingPeriodM.Visibility = Visibility.Collapsed;
            tbTrainingPeriodY.Visibility = Visibility.Collapsed;
            rbBase.Visibility = Visibility.Collapsed;
            rbNoBase.Visibility = Visibility.Collapsed;
            #endregion
        }

        protected virtual void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SpecialtyInfoController specialtyInfoController = new();
            grids.DataContext = SelectedSpecialty;
            lbSpecialtyC.Content = new SpecialtyController().Specialties.Find(x => x.SpecialtyId == SelectedSpecialty.SpecialtyId);
        }

        protected virtual void BtSave_Click(object sender, RoutedEventArgs e) { }

        private void BtEdit_Click(object sender, RoutedEventArgs e)
        {
            AdditionalSpecialtyInfoEditWindow window = new AdditionalSpecialtyInfoEditWindow(SelectedSpecialty);
            window.Show();
            Close();
        }
        protected string GetValueRadioButton()
        {
            if ((bool)rbBase.IsChecked)
                return (string)rbBase.Content;
            else
                return (string)rbNoBase.Content;
        }
    }

    /// <summary>
    /// Редактирование
    /// </summary>
    public sealed class AdditionalSpecialtyInfoEditWindow : AdditionalSpecialtyInfoWindow
    {
        private SpecialtyInformation SelectedSpecialty { get; set; }
        public AdditionalSpecialtyInfoEditWindow(SpecialtyInformation selectedSpecialty) : base()
        {
            Title = "Редактирование профиля";
            SelectedSpecialty = selectedSpecialty;
            #region Настройка интерфейса
            btSave.Visibility = Visibility.Visible;
            lbFormOfEducationC.Visibility = Visibility.Collapsed;
            tbTrainingPeriodM.Visibility = Visibility.Collapsed;
            tbTrainingPeriodM.MinWidth = 20; // минимальный размер окна
            tbTrainingPeriodM.HorizontalContentAlignment = HorizontalAlignment.Center;
            lbBaseNoBase.Visibility = Visibility.Collapsed;
            lbTrainingPeriodC.Visibility = Visibility.Collapsed;
            lbBaseNoBase.Visibility = Visibility.Collapsed;
            tbTrainingPeriodM.Visibility = Visibility.Visible;
            tbTrainingPeriodY.Visibility = Visibility.Visible;
            tbTrainingPeriodY.MinWidth = 20; //минимальный размер окна
            tbTrainingPeriodY.HorizontalContentAlignment = HorizontalAlignment.Center;
            lbTrainingPeriodC.Visibility = Visibility.Collapsed;
            tbTrainingPeriodY.Text = selectedSpecialty.TrainingPeriod.Year.ToString();
            tbTrainingPeriodM.Text = selectedSpecialty.TrainingPeriod.Month.ToString();
            lbM.Visibility = Visibility.Visible; lbY.Visibility = Visibility.Visible;
            #endregion
        }

        protected override void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grids.DataContext = SelectedSpecialty;
            cbFormOfEducation.ItemsSource = new FormOfEducationController().FormOfEducations.ToList();
            cbFormOfEducation.SelectedItem = ((List<FormOfEducation>)cbFormOfEducation.ItemsSource).Find(x => x.FormOfEducationId == SelectedSpecialty.FormOfEducationId);
            cbSpecialty.ItemsSource = new SpecialtyController().Specialties.ToList();
            cbSpecialty.SelectedItem = ((List<Specialty>)cbSpecialty.ItemsSource).Find(x => x.SpecialtyId == SelectedSpecialty.SpecialtyId);

            if (SelectedSpecialty.BaseEndNoBase == rbNoBase.Content.ToString())
                rbNoBase.IsChecked = true;
            else
                rbBase.IsChecked = true;
        }

        protected override void BtSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SelectedSpecialty = (SpecialtyInformation)grids.DataContext;
                SelectedSpecialty.BaseEndNoBase = GetValueRadioButton();
                SelectedSpecialty.FormOfEducationId = ((FormOfEducation)cbFormOfEducation.SelectedItem).FormOfEducationId;
                SelectedSpecialty.SpecialtyId = ((Specialty)cbSpecialty.SelectedItem).SpecialtyId;
                SelectedSpecialty.TrainingPeriod = new DateTime(Convert.ToInt32(tbTrainingPeriodY.Text), Convert.ToInt32(tbTrainingPeriodM.Text), 1);


                MessageBox.Show(SpecialtyInfoController.CreateOrUpdateSpecialtyInformation(SelectedSpecialty));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }

    /// <summary>
    /// Создание
    /// </summary>
    public sealed class AdditionalSpecialtyInfoCreateWindow : AdditionalSpecialtyInfoWindow
    {
        public AdditionalSpecialtyInfoCreateWindow() : base()
        {
            Title = "Создание профиля";
            btSave.Visibility = Visibility.Visible;
            tbTrainingPeriodM.MinWidth = 20; // минимальный размер окна
            tbTrainingPeriodM.HorizontalContentAlignment = HorizontalAlignment.Center;
            tbTrainingPeriodY.MinWidth = 20; //минимальный размер окна
            tbTrainingPeriodY.HorizontalContentAlignment = HorizontalAlignment.Center;
            lbM.Visibility = Visibility.Visible; lbY.Visibility = Visibility.Visible;
        }
        protected override void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbFormOfEducation.ItemsSource = new FormOfEducationController().FormOfEducations.ToList();
            cbSpecialty.ItemsSource = new SpecialtyController().Specialties.ToList();
        }

        protected override void BtSave_Click(object sender, RoutedEventArgs e)
        {
            SpecialtyInformation newSpecialtyInformation;
            if (cbSpecialty.SelectedIndex <0  || cbFormOfEducation.SelectedIndex<0)
            {
                MessageForms.MessageForms.MessageBoxMessage("Выберите специальность и форму обучения");
                return;
            }
            if ((rbBase.IsChecked.Value== false && rbNoBase.IsChecked.Value==false )
                || (rbBase.IsChecked == null || rbNoBase.IsChecked == null)
                )
            {
                MessageForms.MessageForms.MessageBoxMessage("Выберите профиль(базовый или углубленный)");
                return;
            }
            try
            {
                newSpecialtyInformation = CreateUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show(SpecialtyInfoController.CreateOrUpdateSpecialtyInformation(newSpecialtyInformation));
            Close();
        }

        private SpecialtyInformation CreateUser()
        {
            try
            {
               return  new SpecialtyInformation
                (
                    ((Specialty)cbSpecialty.SelectedItem).SpecialtyId,
                    tbName.Text,
                    GetValueRadioButton(),
                    ((FormOfEducation)cbFormOfEducation.SelectedItem).FormOfEducationId,
                    tbTrainingPeriodY.Text, tbTrainingPeriodM.Text
                 );
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}