﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Personnel_Department;

namespace Personnel_Department.Migrations
{
    [DbContext(typeof(MyContecxDB))]
    [Migration("20210204121428_post")]
    partial class post
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.DepartmentInformationName", b =>
                {
                    b.Property<int>("DepartmentInformationNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("DepartmentInformationNameId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentInformationNames");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.DepartmentInformationUser", b =>
                {
                    b.Property<int>("DepartmentInformationUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("DepartmentInformationUserId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("DepartmentInformationUsers");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Direction", b =>
                {
                    b.Property<int>("DirectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("DirectionId");

                    b.ToTable("Directions");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.FormOfEducation", b =>
                {
                    b.Property<int>("FormOfEducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("FormOfEducationId");

                    b.ToTable("FormOfEducations");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Grup", b =>
                {
                    b.Property<int>("GrupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DefaultCountPeoples")
                        .HasColumnType("integer");

                    b.Property<int>("DefaultFreeEducation")
                        .HasColumnType("integer");

                    b.Property<bool>("DisabledGrups")
                        .HasColumnType("boolean");

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("SpecialtyinformationId")
                        .HasColumnType("integer");

                    b.HasKey("GrupId");

                    b.HasIndex("SpecialtyinformationId");

                    b.ToTable("Grups");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.GrupOfCurator", b =>
                {
                    b.Property<int>("GrupOfCuratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GrupId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("GrupOfCuratorId");

                    b.HasIndex("GrupId");

                    b.HasIndex("UserId");

                    b.ToTable("GrupOfCurators");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.GrupOfDepartament", b =>
                {
                    b.Property<int>("GrupOfDepartamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<int>("GrupId")
                        .HasColumnType("integer");

                    b.HasKey("GrupOfDepartamentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GrupId");

                    b.ToTable("GrupOfDepartaments");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Specialty", b =>
                {
                    b.Property<int>("SpecialtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CodeSpecialty")
                        .HasColumnType("text");

                    b.Property<int>("DirectionId")
                        .HasColumnType("integer");

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("SpecialtyId");

                    b.HasIndex("DirectionId");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.SpecialtyInformation", b =>
                {
                    b.Property<int>("SpecialtyinformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("BaseEndNoBase")
                        .HasColumnType("text");

                    b.Property<int>("FormOfEducationId")
                        .HasColumnType("integer");

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("NameProfile")
                        .HasColumnType("text");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TrainingPeriod")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("SpecialtyinformationId");

                    b.HasIndex("FormOfEducationId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("SpecialtyInformation");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudenOfOrphant", b =>
                {
                    b.Property<int>("StudenOfOrphantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("StudenOfOrphantId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudenOfOrphants");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Patronumic")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfAcademic", b =>
                {
                    b.Property<int>("StudentOfAcademicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOffAccademic")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOnAccademic")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GrupId")
                        .HasColumnType("integer");

                    b.Property<string>("OrederOff")
                        .HasColumnType("text");

                    b.Property<string>("OrederOn")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("StudentOfAcademicId");

                    b.HasIndex("GrupId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfAcademics");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfDisabledcs", b =>
                {
                    b.Property<int>("StudentOfDisabledcsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateReference")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ShelfLifeReference")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<string>("TypeDisabledcs")
                        .HasColumnType("text");

                    b.HasKey("StudentOfDisabledcsId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfDisabledcs");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfExternal", b =>
                {
                    b.Property<int>("StudentOfExternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOf")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Docyment")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("StudentOfExternalId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfExternal");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfGrups", b =>
                {
                    b.Property<int>("StudentOfGrupsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOffRegistration")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GrupId")
                        .HasColumnType("integer");

                    b.Property<string>("OrederOff")
                        .HasColumnType("text");

                    b.Property<string>("OrederOn")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("StudentOfGrupsId");

                    b.HasIndex("GrupId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfGrups");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfName", b =>
                {
                    b.Property<int>("StudentOfNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Coment")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateSetName")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("LastPatronumic")
                        .HasColumnType("text");

                    b.Property<string>("LastSurname")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Patronumic")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("StudentOfNameId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentOfNames");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DataOfRegistrations")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateRegistrations")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("ISDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Patronumic")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
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

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.DepartmentInformationUser", b =>
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

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.Grup", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.SpecialtyInformation", "SpecialtyInformations")
                        .WithMany()
                        .HasForeignKey("SpecialtyinformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpecialtyInformations");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.GrupOfCurator", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Grup", "Grups")
                        .WithMany()
                        .HasForeignKey("GrupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personnel_Department.BL.ModelDataBase.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grups");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.GrupOfDepartament", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Department", "Departments")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personnel_Department.BL.ModelDataBase.Grup", "Grups")
                        .WithMany()
                        .HasForeignKey("GrupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudenOfOrphant", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfAcademic", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Grup", "Grups")
                        .WithMany()
                        .HasForeignKey("GrupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grups");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Personnel_Department.BL.ModelDataBase.StudentOfDisabledcs", b =>
                {
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");
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
                    b.HasOne("Personnel_Department.BL.ModelDataBase.Grup", "Grups")
                        .WithMany()
                        .HasForeignKey("GrupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
#pragma warning restore 612, 618
        }
    }
}
