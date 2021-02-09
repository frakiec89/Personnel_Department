using Microsoft.EntityFrameworkCore;
using Personnel_Department.BL.ModelDataBase;

namespace Personnel_Department
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.10.160;Initial Catalog=Personnel_Department_Db; user id =IS_18_02;Password=IS_18_02;");
         //   optionsBuilder.UseNpgsql("Host=192.168.10.160;Port=5432;Database=Personnel_Department_DB_AHT;Username=stud;Password=stud");
        }
            #region Таблицы
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Grups { get; set; }
        public DbSet<DepartmentInformationName> DepartmentInformationNames { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentInformationUser> DepartmentInformationUsers { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<StudentOfAcademic> StudentOfAcademics { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<GroupOfCurator> GrupOfCurators { get; set; }
        public DbSet<GroupOfDepartament> GrupOfDepartaments { get; set; }
        public DbSet<StudentOfDisabledcs> StudentOfDisabledcs { get; set; }
        public DbSet<StudentOfExternal> StudentOfExternal { get; set; }
        public DbSet<StudentOfGrups> StudentOfGrups { get; set; }
        public DbSet<SpecialtyInformation> SpecialtyInformation { get; set; }
        public DbSet<StudenOfOrphant> StudenOfOrphants { get; set; }
        public DbSet<StudentOfName> StudentOfNames { get; set; }
        public DbSet<Student> Students { get; set; }
        #endregion
    }//optionsBuilder.UseMySQL("server=192.168.10.148;port=3306;user=User1;password=DE_01392;database=Personnel_Department_DB_AHT");
}
