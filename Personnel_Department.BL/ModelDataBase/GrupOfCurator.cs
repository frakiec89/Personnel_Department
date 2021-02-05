namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// Назначение кураторов   в группе 
    /// </summary>
    public class GrupOfCurator
    {
        public  int GrupOfCuratorId { get; set; }

        public int GrupId { get; set; }
        public virtual Grup Grups { get; set; }

        public int UserId { get; set; }
        public virtual User Users { get; set; }

        public System.DateTime DateOfOrder { get; set; }

        /// <summary>
        ///  ///комментарии  по  поводу  назначения 
        /// </summary>
        public string Coment { get; set; }

    }
}
