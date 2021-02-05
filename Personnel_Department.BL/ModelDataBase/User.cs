namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// Пользователи, преподаватели , методисты  админы и тд 
    /// </summary>
    public  class User
    {
        public  int  UserId { get; set; }
        public  string Name { get; set; }
        public string Surname { get; set; }

        public  string Patronumic { get; set; }
       
        public System.DateTime DateRegistrations { get; set; }
        public System.DateTime DataOfRegistrations { get; set; }


        /// <summary>
        /// Если  да  то  не  показывать 
        /// </summary>
        public bool ISDeleted { get; set; }

        //Todo  расширить  при  необходимости 

    }
}
