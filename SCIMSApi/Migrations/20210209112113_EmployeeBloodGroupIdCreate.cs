using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class EmployeeBloodGroupIdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodGroupInformations_UserInformations_CreatedBy",
                table: "BloodGroupInformations");

            migrationBuilder.AddColumn<int>(
                name: "BloodGroupId",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "BloodGroupInformations",
                columns: new[] { "Id", "BloodGroup", "CreatedBy", "CreatedDate", "Description", "IsActive" },
                values: new object[] { 1, "B+", 1, new DateTime(2021, 2, 9, 15, 21, 12, 529, DateTimeKind.Local), "New test of blood group added", true });

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

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BloodGroupId", "CreatedDate", "DateofBirth", "HireDate" },
                values: new object[] { 1, new DateTime(2021, 2, 9, 15, 21, 12, 533, DateTimeKind.Local), new DateTime(2021, 2, 9, 15, 21, 12, 533, DateTimeKind.Local), new DateTime(2021, 2, 9, 15, 21, 12, 533, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_BloodGroupId",
                table: "EmployeeInformations",
                column: "BloodGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodGroupInformations_UserInformations_CreatedBy",
                table: "BloodGroupInformations",
                column: "CreatedBy",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_BloodGroupInformations_BloodGroupId",
                table: "EmployeeInformations",
                column: "BloodGroupId",
                principalTable: "BloodGroupInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodGroupInformations_UserInformations_CreatedBy",
                table: "BloodGroupInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_BloodGroupInformations_BloodGroupId",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_BloodGroupId",
                table: "EmployeeInformations");

            migrationBuilder.DeleteData(
                table: "BloodGroupInformations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "BloodGroupId",
                table: "EmployeeInformations");

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 11, 30, 945, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 11, 30, 948, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DepartmentInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 11, 30, 958, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DesignationInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 11, 30, 961, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateofBirth", "HireDate" },
                values: new object[] { new DateTime(2021, 2, 9, 15, 11, 30, 964, DateTimeKind.Local), new DateTime(2021, 2, 9, 15, 11, 30, 964, DateTimeKind.Local), new DateTime(2021, 2, 9, 15, 11, 30, 964, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExamInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 11, 30, 954, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 11, 30, 944, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 15, 11, 30, 942, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_BloodGroupInformations_UserInformations_CreatedBy",
                table: "BloodGroupInformations",
                column: "CreatedBy",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
