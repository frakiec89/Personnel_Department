using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// Пользователи, преподаватели , методисты  админы и тд 
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronumic { get; set; }

        public System.DateTime? DateRegistrations { get; set; }
        public System.DateTime? DateOfDismissal { get; set; }

        [NotMapped]
        public virtual string FullName { get => Name + " " + Surname + "  " + Patronumic; }

        [DefaultValue(false)]
        /// <summary>
        /// Если  да  то  не  показывать 
        /// </summary>
        public bool? ISDeleted { get; set; }

        //Todo  расширить  при  необходимости 

        public override string ToString()
        {
            return FullName;
        }
    }
}
