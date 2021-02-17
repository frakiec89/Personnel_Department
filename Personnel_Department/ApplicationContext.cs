using Microsoft.EntityFrameworkCore;
using Personnel_Department.BL.ModelDataBase;



namespace Personnel_Department
{
    public class ApplicationContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("server=192.168.10.148;port=3306;user=User1;password=DE_01392;database=Personnel_Department_DB_AHT");
            optionsBuilder.UseSqlServer("Server=192.168.10.160;Initial Catalog=Personnel_Department_Db; user id =IS_18_02;Password=IS_18_02;");
          //optionsBuilder.UseNpgsql("Host=192.168.10.160;Port=5432;Database=Personnel_Department_DB_AHT;Username=stud;Password=stud");
        }
            #region Таблицы
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Group> Grups { get; set; }
        public virtual DbSet<DepartmentInformationName> DepartmentInformationNames { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentInformationUsers> DepartmentInformationUsers { get; set; }
        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<FormOfEducation> FormOfEducations { get; set; }
        public virtual DbSet<StudentOfAcademic> StudentOfAcademics { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<GroupOfCurator> GrupOfCurators { get; set; }
        public virtual DbSet<GroupOfDepartament> GrupOfDepartaments { get; set; }
        public virtual DbSet<StudentOfDisabled> StudentOfDisableds { get; set; }
        public virtual DbSet<StudentOfExternal> StudentOfExternal { get; set; }
        public virtual DbSet<StudentOfGrups> StudentOfGrups { get; set; }
        public virtual DbSet<SpecialtyInformation> SpecialtyInformation { get; set; }
        public virtual DbSet<StudenOfOrphant> StudenOfOrphants { get; set; }
        public virtual DbSet<StudentOfName> StudentOfNames { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        #endregion
    }
}
