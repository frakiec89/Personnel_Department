namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// Смена  имени студента 
    /// </summary>
    public class StudentOfName
    {
        public  int StudentOfNameId { get; set; }

        public int  StudentId { get; set; }
        public virtual Student Students { get; set; }


        /// <summary>
        /// дата изменения имени
        /// </summary>
        public System.DateTime DateSetName { get; set; } 

        public string LastName { get; set; }
        public string LastSurname { get; set; }
        public string LastPatronumic { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronumic { get; set; }

        public  string Coment { get; set; }

    }
}
