using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Personnel_Department.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Directions",
                columns: table => new
                {
                    DirectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directions", x => x.DirectionId);
                });

            migrationBuilder.CreateTable(
                name: "FormOfEducations",
                columns: table => new
                {
                    FormOfEducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormOfEducations", x => x.FormOfEducationId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronumic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronumic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRegistrations = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfDismissal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ISDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentInformationNames",
                columns: table => new
                {
                    DepartmentInformationNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DateOfOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInformationNames", x => x.DepartmentInformationNameId);
                    table.ForeignKey(
                        name: "FK_DepartmentInformationNames_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    SpecialtyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeSpecialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectionId = table.Column<int>(type: "int", nullable: false),
                    ISDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.SpecialtyId);
                    table.ForeignKey(
                        name: "FK_Specialties_Directions_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "Directions",
                        principalColumn: "DirectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudenOfOrphants",
                columns: table => new
                {
                    StudenOfOrphantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudenOfOrphants", x => x.StudenOfOrphantId);
                    table.ForeignKey(
                        name: "FK_StudenOfOrphants_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentOfDisabledcs",
                columns: table => new
                {
                    StudentOfDisabledcsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    TypeDisabledcs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateReference = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShelfLifeReference = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentOfDisabledcs", x => x.StudentOfDisabledcsId);
                    table.ForeignKey(
                        name: "FK_StudentOfDisabledcs_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentOfExternal",
                columns: table => new
                {
                    StudentOfExternalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOf = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docyment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentOfExternal", x => x.StudentOfExternalId);
                    table.ForeignKey(
                        name: "FK_StudentOfExternal_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentOfNames",
                columns: table => new
                {
                    StudentOfNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    DateSetName = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastPatronumic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronumic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentOfNames", x => x.StudentOfNameId);
                    table.ForeignKey(
                        name: "FK_StudentOfNames_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentInformationUsers",
                columns: table => new
                {
                    DepartmentInformationUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DateOfOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInformationUsers", x => x.DepartmentInformationUserId);
                    table.ForeignKey(
                        name: "FK_DepartmentInformationUsers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentInformationUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialtyInformation",
                columns: table => new
                {
                    SpecialtyinformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialtyId = table.Column<int>(type: "int", nullable: false),
                    NameProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseEndNoBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormOfEducationId = table.Column<int>(type: "int", nullable: false),
                    ISDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialtyInformation", x => x.SpecialtyinformationId);
                    table.ForeignKey(
                        name: "FK_SpecialtyInformation_FormOfEducations_FormOfEducationId",
                        column: x => x.FormOfEducationId,
                        principalTable: "FormOfEducations",
                        principalColumn: "FormOfEducationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialtyInformation_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "SpecialtyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grups",
                columns: table => new
                {
                    GrupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecialtyinformationId = table.Column<int>(type: "int", nullable: false),
                    DefaultCountPeoples = table.Column<int>(type: "int", nullable: false),
                    DisabledGrups = table.Column<bool>(type: "bit", nullable: false),
                    DefaultFreeEducation = table.Column<int>(type: "int", nullable: false),
                    ISDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grups", x => x.GrupId);
                    table.ForeignKey(
                        name: "FK_Grups_SpecialtyInformation_SpecialtyinformationId",
                        column: x => x.SpecialtyinformationId,
                        principalTable: "SpecialtyInformation",
                        principalColumn: "SpecialtyinformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrupOfCurators",
                columns: table => new
                {
                    GrupOfCuratorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupId = table.Column<int>(type: "int", nullable: false),
                    GrupsGrupId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateOfOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupOfCurators", x => x.GrupOfCuratorId);
                    table.ForeignKey(
                        name: "FK_GrupOfCurators_Grups_GrupsGrupId",
                        column: x => x.GrupsGrupId,
                        principalTable: "Grups",
                        principalColumn: "GrupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GrupOfCurators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrupOfDepartaments",
                columns: table => new
                {
                    GrupOfDepartamentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupId = table.Column<int>(type: "int", nullable: false),
                    GrupsGrupId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DateOfOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupOfDepartaments", x => x.GrupOfDepartamentId);
                    table.ForeignKey(
                        name: "FK_GrupOfDepartaments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupOfDepartaments_Grups_GrupsGrupId",
                        column: x => x.GrupsGrupId,
                        principalTable: "Grups",
                        principalColumn: "GrupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentOfAcademics",
                columns: table => new
                {
                    StudentOfAcademicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    GrupId = table.Column<int>(type: "int", nullable: false),
                    GrupsGrupId = table.Column<int>(type: "int", nullable: true),
                    DateOnAccademic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOffAccademic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrederOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrederOff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentOfAcademics", x => x.StudentOfAcademicId);
                    table.ForeignKey(
                        name: "FK_StudentOfAcademics_Grups_GrupsGrupId",
                        column: x => x.GrupsGrupId,
                        principalTable: "Grups",
                        principalColumn: "GrupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentOfAcademics_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentOfGrups",
                columns: table => new
                {
                    StudentOfGrupsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    GrupId = table.Column<int>(type: "int", nullable: false),
                    GrupsGrupId = table.Column<int>(type: "int", nullable: true),
                    DateRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOffRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrederOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrederOff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentOfGrups", x => x.StudentOfGrupsId);
                    table.ForeignKey(
                        name: "FK_StudentOfGrups_Grups_GrupsGrupId",
                        column: x => x.GrupsGrupId,
                        principalTable: "Grups",
                        principalColumn: "GrupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentOfGrups_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInformationNames_DepartmentId",
                table: "DepartmentInformationNames",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInformationUsers_DepartmentId",
                table: "DepartmentInformationUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInformationUsers_UserId",
                table: "DepartmentInformationUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupOfCurators_GrupsGrupId",
                table: "GrupOfCurators",
                column: "GrupsGrupId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupOfCurators_UserId",
                table: "GrupOfCurators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupOfDepartaments_DepartmentId",
                table: "GrupOfDepartaments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupOfDepartaments_GrupsGrupId",
                table: "GrupOfDepartaments",
                column: "GrupsGrupId");

            migrationBuilder.CreateIndex(
                name: "IX_Grups_SpecialtyinformationId",
                table: "Grups",
                column: "SpecialtyinformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_DirectionId",
                table: "Specialties",
                column: "DirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialtyInformation_FormOfEducationId",
                table: "SpecialtyInformation",
                column: "FormOfEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialtyInformation_SpecialtyId",
                table: "SpecialtyInformation",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudenOfOrphants_StudentId",
                table: "StudenOfOrphants",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentOfAcademics_GrupsGrupId",
                table: "StudentOfAcademics",
                column: "GrupsGrupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentOfAcademics_StudentId",
                table: "StudentOfAcademics",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentOfDisabledcs_StudentId",
                table: "StudentOfDisabledcs",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentOfExternal_StudentId",
                table: "StudentOfExternal",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentOfGrups_GrupsGrupId",
                table: "StudentOfGrups",
                column: "GrupsGrupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentOfGrups_StudentId",
                table: "StudentOfGrups",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentOfNames_StudentId",
                table: "StudentOfNames",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentInformationNames");

            migrationBuilder.DropTable(
                name: "DepartmentInformationUsers");

            migrationBuilder.DropTable(
                name: "GrupOfCurators");

            migrationBuilder.DropTable(
                name: "GrupOfDepartaments");

            migrationBuilder.DropTable(
                name: "StudenOfOrphants");

            migrationBuilder.DropTable(
                name: "StudentOfAcademics");

            migrationBuilder.DropTable(
                name: "StudentOfDisabledcs");

            migrationBuilder.DropTable(
                name: "StudentOfExternal");

            migrationBuilder.DropTable(
                name: "StudentOfGrups");

            migrationBuilder.DropTable(
                name: "StudentOfNames");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Grups");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SpecialtyInformation");

            migrationBuilder.DropTable(
                name: "FormOfEducations");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "Directions");
        }
    }
}
