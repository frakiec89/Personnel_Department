﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Personnel_Department;

namespace Personnel_Department.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.DepartmentInformationName", b =>
                {
                    b.Property<int>("DepartmentInformationNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentInformationNameId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentInformationNames");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.DepartmentInformationUsers", b =>
                {
                    b.Property<int>("DepartmentInformationUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentInformationUserId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("DepartmentInformationUsers");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Direction", b =>
                {
                    b.Property<int>("DirectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirectionId");

                    b.ToTable("Directions");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.FormOfEducation", b =>
                {
                    b.Property<int>("FormOfEducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormOfEducationId");

                    b.ToTable("FormOfEducations");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Group", b =>
                {
                    b.Property<int>("GrupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefaultCountPeoples")
                        .HasColumnType("int");

                    b.Property<int>("DefaultFreeEducation")
                        .HasColumnType("int");

                    b.Property<bool>("DisabledGrups")
                        .HasColumnType("bit");

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialtyinformationId")
                        .HasColumnType("int");

                    b.HasKey("GrupId");

                    b.HasIndex("SpecialtyinformationId");

                    b.ToTable("Grups");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.GroupOfCurator", b =>
                {
                    b.Property<int>("GrupOfCuratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("GrupId")
                        .HasColumnType("int");

                    b.Property<int?>("GrupsGrupId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GrupOfCuratorId");

                    b.HasIndex("GrupsGrupId");

                    b.HasIndex("UserId");

                    b.ToTable("GrupOfCurators");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.GroupOfDepartament", b =>
                {
                    b.Property<int>("GrupOfDepartamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("GrupId")
                        .HasColumnType("int");

                    b.Property<int?>("GrupsGrupId")
                        .HasColumnType("int");

                    b.HasKey("GrupOfDepartamentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GrupsGrupId");

                    b.ToTable("GrupOfDepartaments");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Specialty", b =>
                {
                    b.Property<int>("SpecialtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeSpecialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DirectionId")
                        .HasColumnType("int");

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecialtyId");

                    b.HasIndex("DirectionId");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.SpecialtyInformation", b =>
                {
                    b.Property<int>("SpecialtyinformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseEndNoBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormOfEducationId")
                        .HasColumnType("int");

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TrainingPeriod")
                        .HasColumnType("datetime2");

                    b.HasKey("SpecialtyinformationId");

                    b.HasIndex("FormOfEducationId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("SpecialtyInformation");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronumic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfAcademic", b =>
                {
                    b.Property<int>("StudentOfAcademicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOffAccademic")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOnAccademic")
                        .HasColumnType("datetime2");

                    b.Property<int>("GrupId")
                        .HasColumnType("int");

                    b.Property<int?>("GrupsGrupId")
                        .HasColumnType("int");

                    b.Property<string>("OrederOff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrederOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentOfAcademicId");

                    b.HasIndex("GrupsGrupId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfAcademics");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfExternal", b =>
                {
                    b.Property<int>("StudentOfExternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOf")
                        .HasColumnType("datetime2");

                    b.Property<string>("Docyment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentOfExternalId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfExternal");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfGrups", b =>
                {
                    b.Property<int>("StudentOfGrupsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOffRegistration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<int>("GrupId")
                        .HasColumnType("int");

                    b.Property<int?>("GrupsGrupId")
                        .HasColumnType("int");

                    b.Property<string>("OrederOff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrederOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentOfGrupsId");

                    b.HasIndex("GrupsGrupId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfGrups");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfName", b =>
                {
                    b.Property<int>("StudentOfNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateSetName")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastPatronumic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronumic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentOfNameId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfNames");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfDismissal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRegistrations")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool?>("ISDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronumic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudenOfOrphant", b =>
                {
                    b.HasBaseType("Personnel_Department.BL.ModelDataBase.Student");

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudenOfOrphantId")
                        .HasColumnType("int");

                    b.ToTable("StudenOfOrphant");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfDisabled", b =>
                {
                    b.HasBaseType("Personnel_Department.BL.ModelDataBase.Student");

                    b.Property<string>("Coment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateReference")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShelfLifeReference")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentOfDisabledId")
                        .HasColumnType("int");

                    b.Property<string>("TypeDisabled")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("StudentOfDisabled");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.DepartmentInformationName", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Department", "Departments")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.DepartmentInformationUsers", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Department", "Departments")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personnel_Department.BL.ModelDataBase.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Group", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.SpecialtyInformation", "SpecialtyInformations")
                        .WithMany()
                        .HasForeignKey("SpecialtyinformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpecialtyInformations");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.GroupOfCurator", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Group", "Grups")
                        .WithMany()
                        .HasForeignKey("GrupsGrupId");

                    b.HasOne("Personnel_Department.BL.ModelDataBase.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grups");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.GroupOfDepartament", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Department", "Departments")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personnel_Department.BL.ModelDataBase.Group", "Grups")
                        .WithMany()
                        .HasForeignKey("GrupsGrupId");

                    b.Navigation("Departments");

                    b.Navigation("Grups");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Specialty", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Direction", "Directions")
                        .WithMany()
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Directions");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.SpecialtyInformation", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.FormOfEducation", "FormOfEducations")
                        .WithMany()
                        .HasForeignKey("FormOfEducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personnel_Department.BL.ModelDataBase.Specialty", "Specialtys")
                        .WithMany()
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormOfEducations");

                    b.Navigation("Specialtys");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfAcademic", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Group", "Grups")
                        .WithMany()
                        .HasForeignKey("GrupsGrupId");

                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grups");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfExternal", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfGrups", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Group", "Grups")
                        .WithMany()
                        .HasForeignKey("GrupsGrupId");

                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grups");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfName", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudenOfOrphant", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", null)
                        .WithOne()
                        .HasForeignKey("Personnel_Department.BL.ModelDataBase.StudenOfOrphant", "StudentId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfDisabled", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", null)
                        .WithOne()
                        .HasForeignKey("Personnel_Department.BL.ModelDataBase.StudentOfDisabled", "StudentId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
