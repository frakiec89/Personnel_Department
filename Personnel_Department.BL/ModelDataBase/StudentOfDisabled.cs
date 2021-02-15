namespace Personnel_Department.BL.ModelDataBase
{
    [System.ComponentModel.DataAnnotations.Schema.Table("StudentOfDisabled")]
    /// <summary>
    /// Студенты инвалиды
    /// </summary>
    public class StudentOfDisabled: Student
    {
        public int StudentOfDisabledId { get; set; }

        /// <summary>
        /// Вид  инвалидности
        /// </summary>
        public string TypeDisabled { get; set; }

        /// <summary>
        /// Дата выдачи  справки
        /// </summary>
         public System.DateTime DateReference { get; set; }

        /// <summary>
        /// Срок  справки (дата  окончания )
        /// </summary>
        public System.DateTime ShelfLifeReference { get; set; }
        public string Coment { get; set; }

    }
}
