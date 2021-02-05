namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// 
    /// </summary>
    public  class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronumic { get; set; }

        /// <summary>
        /// Если  да  то  не  показывать 
        /// </summary>
        public bool ISDeleted { get; set; }
        // todo -дописать 
    }
}
