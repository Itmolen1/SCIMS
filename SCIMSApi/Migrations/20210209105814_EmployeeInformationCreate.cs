using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class EmployeeInformationCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInformation_UserInformations_CreatedBy",
                table: "DepartmentInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInformation_SchoolInformations_SchoolId",
                table: "DepartmentInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignationInformation_UserInformations_CreatedBy",
                table: "DesignationInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignationInformation_SchoolInformations_SchoolId",
                table: "DesignationInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DesignationInformation",
                table: "DesignationInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentInformation",
                table: "DepartmentInformation");

            migrationBuilder.RenameTable(
                name: "DesignationInformation",
                newName: "DesignationInformations");

            migrationBuilder.RenameTable(
                name: "DepartmentInformation",
                newName: "DepartmentInformations");

            migrationBuilder.RenameIndex(
                name: "IX_DesignationInformation_SchoolId",
                table: "DesignationInformations",
                newName: "IX_DesignationInformations_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_DesignationInformation_CreatedBy",
                table: "DesignationInformations",
                newName: "IX_DesignationInformations_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentInformation_SchoolId",
                table: "DepartmentInformations",
                newName: "IX_DepartmentInformations_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentInformation_CreatedBy",
                table: "DepartmentInformations",
                newName: "IX_DepartmentInformations_CreatedBy");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "EmployeeInformations",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "EmployeeInformations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactNumber",
                table: "EmployeeInformations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "EmployeeInformations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "EmployeeInformations",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DesignationInformations",
                table: "DesignationInformations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentInformations",
                table: "DepartmentInformations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 14, 58, 14, 246, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 14, 58, 14, 249, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DepartmentInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 14, 58, 14, 260, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DesignationInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 14, 58, 14, 263, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateofBirth", "DepartmentId", "GenderId", "HireDate" },
                values: new object[] { new DateTime(2021, 2, 9, 14, 58, 14, 265, DateTimeKind.Local), new DateTime(2021, 2, 9, 14, 58, 14, 265, DateTimeKind.Local), 1, 1, new DateTime(2021, 2, 9, 14, 58, 14, 265, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExamInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 14, 58, 14, 256, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 14, 58, 14, 245, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 9, 14, 58, 14, 243, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_DepartmentId",
                table: "EmployeeInformations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_GenderId",
                table: "EmployeeInformations",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInformations_UserInformations_CreatedBy",
                table: "DepartmentInformations",
                column: "CreatedBy",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInformations_SchoolInformations_SchoolId",
                table: "DepartmentInformations",
                column: "SchoolId",
                principalTable: "SchoolInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignationInformations_UserInformations_CreatedBy",
                table: "DesignationInformations",
                column: "CreatedBy",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignationInformations_SchoolInformations_SchoolId",
                table: "DesignationInformations",
                column: "SchoolId",
                principalTable: "SchoolInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_DepartmentInformations_DepartmentId",
                table: "EmployeeInformations",
                column: "DepartmentId",
                principalTable: "DepartmentInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_Genders_GenderId",
                table: "EmployeeInformations",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInformations_UserInformations_CreatedBy",
                table: "DepartmentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInformations_SchoolInformations_SchoolId",
                table: "DepartmentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignationInformations_UserInformations_CreatedBy",
                table: "DesignationInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_DesignationInformations_SchoolInformations_SchoolId",
                table: "DesignationInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_DepartmentInformations_DepartmentId",
                table: "EmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_Genders_GenderId",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_DepartmentId",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_GenderId",
                table: "EmployeeInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DesignationInformations",
                table: "DesignationInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentInformations",
                table: "DepartmentInformations");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "EmergencyContactNumber",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "EmployeeInformations");

            migrationBuilder.RenameTable(
                name: "DesignationInformations",
                newName: "DesignationInformation");

            migrationBuilder.RenameTable(
                name: "DepartmentInformations",
                newName: "DepartmentInformation");

            migrationBuilder.RenameIndex(
                name: "IX_DesignationInformations_SchoolId",
                table: "DesignationInformation",
                newName: "IX_DesignationInformation_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_DesignationInformations_CreatedBy",
                table: "DesignationInformation",
                newName: "IX_DesignationInformation_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentInformations_SchoolId",
                table: "DepartmentInformation",
                newName: "IX_DepartmentInformation_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentInformations_CreatedBy",
                table: "DepartmentInformation",
                newName: "IX_DepartmentInformation_CreatedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DesignationInformation",
                table: "DesignationInformation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentInformation",
                table: "DepartmentInformation",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 14, 10, 47, 72, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 14, 10, 47, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DepartmentInformation",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 14, 10, 47, 98, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "DesignationInformation",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 14, 10, 47, 105, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateofBirth" },
                values: new object[] { new DateTime(2021, 2, 8, 14, 10, 47, 107, DateTimeKind.Local), new DateTime(2021, 2, 8, 14, 10, 47, 107, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExamInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 14, 10, 47, 89, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 14, 10, 47, 71, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 14, 10, 47, 67, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInformation_UserInformations_CreatedBy",
                table: "DepartmentInformation",
                column: "CreatedBy",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInformation_SchoolInformations_SchoolId",
                table: "DepartmentInformation",
                column: "SchoolId",
                principalTable: "SchoolInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignationInformation_UserInformations_CreatedBy",
                table: "DesignationInformation",
                column: "CreatedBy",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignationInformation_SchoolInformations_SchoolId",
                table: "DesignationInformation",
                column: "SchoolId",
                principalTable: "SchoolInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
