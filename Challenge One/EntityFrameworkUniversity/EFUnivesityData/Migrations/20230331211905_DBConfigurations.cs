using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFUnivesityData.Migrations
{
    public partial class DBConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 3, 31, 15, 19, 5, 34, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 3, 31, 15, 19, 5, 34, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2023, 3, 31, 15, 19, 5, 34, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2023, 3, 31, 15, 19, 5, 34, DateTimeKind.Local).AddTicks(988));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 3, 31, 11, 52, 41, 764, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 3, 31, 11, 52, 41, 764, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2023, 3, 31, 11, 52, 41, 764, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2023, 3, 31, 11, 52, 41, 764, DateTimeKind.Local).AddTicks(8233));
        }
    }
}
