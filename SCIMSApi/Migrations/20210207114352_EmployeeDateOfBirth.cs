using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class EmployeeDateOfBirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateofBirth",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 7, 15, 43, 51, 371, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 7, 15, 43, 51, 374, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateofBirth" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 43, 51, 383, DateTimeKind.Local), new DateTime(2021, 2, 7, 15, 43, 51, 383, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExamInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 7, 15, 43, 51, 381, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 7, 15, 43, 51, 370, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 7, 15, 43, 51, 368, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "EmployeeInformations");

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 6, 16, 52, 41, 431, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 6, 16, 52, 41, 435, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 6, 16, 52, 41, 444, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExamInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 6, 16, 52, 41, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 6, 16, 52, 41, 431, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 6, 16, 52, 41, 429, DateTimeKind.Local));
        }
    }
}
