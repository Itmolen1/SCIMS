using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class BloodGroupSchoolIdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "BloodGroupInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BloodGroupInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "SchoolId" },
                values: new object[] { new DateTime(2021, 2, 9, 16, 2, 33, 199, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 16, 2, 33, 183, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 16, 2, 33, 185, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DepartmentInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 16, 2, 33, 194, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DesignationInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 16, 2, 33, 198, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Age", "CreatedDate", "DateofBirth", "EmailAddress", "EmergencyContactNumber", "HireDate", "ImageUrl", "MobileNumber" },
                values: new object[] { "Abu Dhabi Uae", 30, new DateTime(2021, 2, 9, 16, 2, 33, 202, DateTimeKind.Local), new DateTime(2021, 2, 9, 16, 2, 33, 202, DateTimeKind.Local), "Employee@test.com", "123 4546456", new DateTime(2021, 2, 9, 16, 2, 33, 204, DateTimeKind.Local), "noImage.png", "1235 12132131" });

            migrationBuilder.UpdateData(
                table: "ExamInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 16, 2, 33, 190, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 16, 2, 33, 183, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 16, 2, 33, 180, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_BloodGroupInformations_SchoolId",
                table: "BloodGroupInformations",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodGroupInformations_SchoolInformations_SchoolId",
                table: "BloodGroupInformations",
                column: "SchoolId",
                principalTable: "SchoolInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodGroupInformations_SchoolInformations_SchoolId",
                table: "BloodGroupInformations");

            migrationBuilder.DropIndex(
                name: "IX_BloodGroupInformations_SchoolId",
                table: "BloodGroupInformations");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "BloodGroupInformations");

            migrationBuilder.UpdateData(
                table: "BloodGroupInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 21, 12, 529, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 21, 12, 482, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 21, 12, 491, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DepartmentInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 21, 12, 520, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DesignationInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 21, 12, 527, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Age", "CreatedDate", "DateofBirth", "EmailAddress", "EmergencyContactNumber", "HireDate", "ImageUrl", "MobileNumber" },
                values: new object[] { null, 0, new DateTime(2021, 2, 9, 15, 21, 12, 533, DateTimeKind.Local), new DateTime(2021, 2, 9, 15, 21, 12, 533, DateTimeKind.Local), null, null, new DateTime(2021, 2, 9, 15, 21, 12, 533, DateTimeKind.Local), null, null });

            migrationBuilder.UpdateData(
                table: "ExamInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 21, 12, 507, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 21, 12, 481, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 21, 12, 478, DateTimeKind.Local));
        }
    }
}
