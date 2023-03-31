using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFUnivesityData.Migrations
{
    public partial class DBCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FirstMidName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FirstMidName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Budget = table.Column<float>(type: "real", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficeAssignments",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_OfficeAssignments_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Credits = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseAssignments",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CourseAssignments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.NoAction,
                        onUpdate: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CourseAssignments_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "FirstMidName", "HireDate", "LastName" },
                values: new object[] { 1, "Juan", new DateTime(2023, 3, 31, 11, 52, 41, 764, DateTimeKind.Local).AddTicks(8387), "Solares" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { 1, new DateTime(2023, 3, 31, 11, 52, 41, 764, DateTimeKind.Local).AddTicks(8221), "Carlos", "Che" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { 2, new DateTime(2023, 3, 31, 11, 52, 41, 764, DateTimeKind.Local).AddTicks(8233), "Agustin", "Mijangos" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "InstructorId", "Name", "StartDate" },
                values: new object[] { 1, 90000f, 1, "Engenierr", new DateTime(2023, 3, 31, 11, 52, 41, 764, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Credits", "DepartmentId", "Title" },
                values: new object[] { 1, 5, 1, "Progra 1" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Credits", "DepartmentId", "Title" },
                values: new object[] { 2, 4, 1, "Progra 2" });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[] { 1, 1, 50f, 1 });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[] { 2, 1, 80f, 2 });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[] { 3, 2, 70f, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignments_CourseId",
                table: "CourseAssignments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignments_InstructorId",
                table: "CourseAssignments",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments",
                column: "InstructorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId_StudentId",
                table: "Enrollments",
                columns: new[] { "CourseId", "StudentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeAssignments_InstructorId",
                table: "OfficeAssignments",
                column: "InstructorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseAssignments");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "OfficeAssignments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
