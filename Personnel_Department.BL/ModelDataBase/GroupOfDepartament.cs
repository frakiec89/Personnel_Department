namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// Распределение  группы за  отделением 
    /// </summary>
    public class GroupOfDepartament
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int GrupOfDepartamentId { get; set; }
        public int GrupId { get; set; }
        public virtual Group Grups { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; }
        public System.DateTime DateOfOrder { get; set; }
        /// <summary>
        ///  ///комментарии  по  поводу  назначения 
        /// </summary>
        public string Coment { get; set; }
    }
}