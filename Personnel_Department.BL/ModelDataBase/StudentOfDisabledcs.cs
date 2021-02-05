namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// Студенты инвалиды
    /// </summary>
    public class StudentOfDisabledcs
    {
        public int StudentOfDisabledcsId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Students { get; set; }

        /// <summary>
        /// Вид  инвалидности
        /// </summary>
        public string TypeDisabledcs { get; set; }

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
