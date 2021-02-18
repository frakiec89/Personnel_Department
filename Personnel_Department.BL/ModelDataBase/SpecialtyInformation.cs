using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// Срок обучения ,профиль , форма обучения
    /// </summary>
    public class SpecialtyInformation
    {
        public SpecialtyInformation() { }
        /// <summary>
        /// С готовой датой
        /// </summary>
        /// <param name="specialtyId"></param>
        /// <param name="nameProfile">Имя профиля</param>
        /// <param name="baseEndNoBase">Тип обучения(Базовый или углубленный)</param>
        /// <param name="trainingPeriod">Период обучения</param>
        /// <param name="formOfEducationId"></param>
        public SpecialtyInformation(int? specialtyId, string nameProfile, string baseEndNoBase,
            int? formOfEducationId, DateTime trainingPeriod)
        {
            if (specialtyId is null)
            {
                throw new ArgumentNullException("Не выбрана специальность");
            }

            if (formOfEducationId is null)
            {
                throw new ArgumentNullException("Не форма обучения");
            }

            SpecialtyId = specialtyId.Value;
            NameProfile = nameProfile ?? throw new ArgumentNullException("Введите имя");
            BaseEndNoBase = baseEndNoBase ?? throw new ArgumentNullException("Выберите тип");
            TrainingPeriod = trainingPeriod;
            FormOfEducationId = formOfEducationId.Value;
        }
        /// <summary>
        /// С не готовой датой
        /// </summary>
        /// <param name="specialtyId"></param>
        /// <param name="nameProfile">Имя профиля</param>
        /// <param name="baseEndNoBase">Тип обучения(Базовый или углубленный)</param>
        /// <param name="formOfEducationId"></param>
        /// <param name="year">Год строкой</param>
        /// <param name="month">Месяц строкой</param>
        public SpecialtyInformation(int specialtyId, string nameProfile, string baseEndNoBase, int formOfEducationId,
            string year, string month) : this(specialtyId, nameProfile, baseEndNoBase, formOfEducationId, new DateTime())
        {
            TrainingPeriod = GetDate(year, month);
        }
        private static DateTime GetDate(string year, string month)
        {
            if (int.TryParse(year, out int result) && int.TryParse(month, out int result2))
            {
                return new DateTime(year: result, month: result2, day: 1);
            }
            else
            {
                throw new ArgumentException("Дата введена не верно");
            }
        }

        public int SpecialtyinformationId { get; set; }
        public int SpecialtyId { get; set; }
        public virtual Specialty Specialtys { get; set; }
        /// <summary>
        /// Наличие профиля  - например  у гр  ИС-18-02 - профиль - администратор  БД 
        /// </summary>
        public string NameProfile { get; set; }
        /// <summary>
        /// углубленно - не углубленно
        /// </summary>
        public string BaseEndNoBase { get; set; }
        /// <summary>
        /// Срок  обучения , например  4 года 10 месяцев
        /// </summary>
        public System.DateTime TrainingPeriod { get; set; }
        [NotMapped]
        public virtual string GetTrainingPeriod { get => TrainingPeriod.Year.ToString() + " г." + ' ' + TrainingPeriod.Month.ToString() + " м. "; }
        public int FormOfEducationId { get; set; }
        public FormOfEducation FormOfEducations { get; set; }
        /// <summary>
        /// Если  да  то  не  показывать 
        /// </summary>
        public bool ISDeleted { get; set; }
        public override string ToString() => NameProfile;
    }
}