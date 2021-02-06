using System.ComponentModel.DataAnnotations;

namespace Personnel_Department.BL.ModelDataBase
{
    /// <summary>
    /// Назначение кураторов   в группе 
    /// </summary>
    public class GroupOfCurator
    {
        [Key]
        public  int GrupOfCuratorId { get; set; }

        public int GrupId { get; set; }
        public virtual Group Grups { get; set; }

        public int UserId { get; set; }
        public virtual User Users { get; set; }

        public System.DateTime DateOfOrder { get; set; }

        /// <summary>
        ///  ///комментарии  по  поводу  назначения 
        /// </summary>
        public string Coment { get; set; }

    }
}
