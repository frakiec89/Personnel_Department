namespace Personnel_Department.BL.ModelDataBase
{
    [System.ComponentModel.DataAnnotations.Schema.Table("DepartmentInformationUser")]
    /// <summary>
    /// класс для переназначения  зав Отделением 
    /// </summary>
    public class DepartmentInformationUser: Department
    {
        public System.DateTime DateOfOrder { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// Зав отделением 
        /// </summary>
        public virtual User Users { get; set; }

        /// комментарии  по  поводу назначения
        public string Coment { get; set; }
    }

    
}
