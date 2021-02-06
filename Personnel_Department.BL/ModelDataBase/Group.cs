using System.ComponentModel.DataAnnotations;

namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// Учебные группы  - например ис-18-02 (специальность - год  -  порядковый номер)
    /// </summary>
    public class Group
    {
        [Key]
        public  int GrupId { get; set; }
        public  string Name { get; set; }

        /// <summary>
        /// Дата открытия  группы // например группа кс-16 открыта 01.09.2016 
        /// </summary>
        public  System.DateTime DateRegistration { get; set; }

        public int SpecialtyinformationId { get; set; }

        /// <summary>
        /// Информация о  специальности  а  так  же  о  сроке обучения 
        /// </summary>
        public  SpecialtyInformation SpecialtyInformations { get; set; }

        /// <summary>
        /// Стандартное число  учащихся  в  группе 
        /// </summary>
        public  int DefaultCountPeoples { get; set; }

        /// <summary>
        /// Наличие ограничений  по  инвалидности  в группе // например  группа ПКС-17-01 открыта для людей с ограничениями
        /// </summary>
        public bool DisabledGrups { get; set; }

        /// <summary>
        /// Количество бюджетный мест // например  в группе  кс-16 при поступлении все учащиеся были приняты на  бюджет 
        /// </summary>
        public int DefaultFreeEducation { get; set; }

        /// <summary>
        /// Если  да  то  не  показывать 
        /// </summary>
        public bool ISDeleted { get; set; }

    }
}
