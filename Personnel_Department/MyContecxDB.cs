using Microsoft.EntityFrameworkCore;
using Personnel_Department.BL.ModelDataBase;

namespace Personnel_Department
{
    public class MyContecxDB :DbContext 
    {
        public MyContecxDB () => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => // optionsBuilder.UseMySQL("server=192.168.10.148;port=3306;user=User1;password=DE_01392;database=Personnel_Department_DB_AHT");
            optionsBuilder.UseNpgsql("Host=192.168.10.160;port=5432;Username=stud;password=stud;database=Personnel_Department_DB_AHT");

        #region Таблицы
        public DbSet<User> Users { get; set; }
        public DbSet<Grup> Grups { get; set; }
        public DbSet<DepartmentInformationName> DepartmentInformationNames { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentInformationUser> DepartmentInformationUsers { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<StudentOfAcademic> StudentOfAcademics { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<GrupOfCurator> GrupOfCurators { get; set; }
        public DbSet<GrupOfDepartament> GrupOfDepartaments { get; set; }
        public DbSet<StudentOfDisabledcs> StudentOfDisabledcs { get; set; }
        public DbSet<StudentOfExternal> StudentOfExternal { get; set; }
        public DbSet<StudentOfGrups> StudentOfGrups { get; set; }
        public DbSet<SpecialtyInformation> SpecialtyInformation { get; set; }
        public DbSet<StudenOfOrphant> StudenOfOrphants { get; set; }
        public DbSet<StudentOfName> StudentOfNames { get; set; }
        public DbSet<Student> Students { get; set; }
        #endregion



    }

    /*
     public  class  MyPosgresSql : MyContecxDB
     {
         public MyPosgresSql() : base() 
         {}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseNpgsql("Host=192.168.10.160;port=5432;user=stud;password=stud;database=Personnel_Department_DB_AHT");
         }
     }*/

}
