namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// Специальности, например 09.02.07 компьютерные системы   и  комплексы
    /// </summary>
    public class Specialty
    {
       public int  SpecialtyId { get; set; }
       /// <summary>
        /// Например 09.02.07
        /// </summary>
       public string CodeSpecialty { get; set; }
       public string Name { get; set; }
       public int DirectionId { get; set; }
       public virtual Direction Directions { get; set; }

        /// <summary>
        /// Если  да  то  не  показывать 
        /// </summary>
        public bool ISDeleted { get; set; }

        public override string ToString()
        {
            return  string.Format("({0}) - {1} ((c сгк)) ) ", CodeSpecialty , Name ) ;
        }

    }
}
