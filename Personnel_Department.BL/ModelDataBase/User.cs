using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Personnel_Department.BL.ModelDataBase
{

    /// <summary>
    /// Пользователи, преподаватели , методисты  админы и тд 
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronumic { get; set; }

        [Required]
        public System.DateTime? DateRegistrations { get; set; }
        public System.DateTime? DateOfDismissal { get; set; }

        [NotMapped]
        public virtual string FullName { get => Name + " " + Surname + " " + Patronumic; set { FullName = value; } }

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
