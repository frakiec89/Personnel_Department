namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// Срок обучения ,профиль , форма обучения
    /// </summary>
    public class SpecialtyInformation
    {
       public int  SpecialtyinformationId { get; set; }

       public int SpecialtyId { get; set; }
       public  virtual Specialty Specialtys { get; set; }

       /// <summary>
        /// Наличие профиля  - например  у гр  ИС-18-02 - профиль - администратор  БД 
        /// </summary>
       public string NameProfile { get; set; }

        /// <summary>
        /// углубленно - не углубленно
        /// </summary>
        public string BaseEndNoBase { get; set; }
       /// <summary>
        /// срок  обучения , например  4 года 10 месяцев
        /// </summary>
       public  System.DateTime TrainingPeriod { get; set; }
     
       public  int   FormOfEducationId { get; set; }
       public FormOfEducation FormOfEducations { get; set; }


        /// <summary>
        /// Если  да  то  не  показывать 
        /// </summary>
        public bool ISDeleted { get; set; }
    }
}
