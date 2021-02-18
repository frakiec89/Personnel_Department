namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// класс для переназначения  зав Отделением 
    /// </summary>
    public class DepartmentInformationUsers
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int DepartmentInformationUserId { get; set; }
        public System.DateTime DateOfOrder { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// Зав отделением 
        /// </summary>
        public virtual User Users { get; set; }
        /// <summary>
        ///Комментарии  по  поводу назначения
        /// </summary>
        public string Coment { get; set; }
    }
}