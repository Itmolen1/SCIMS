using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class DepatmentInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 600, nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentInformation_UserInformations_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentInformation_SchoolInformations_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "SchoolInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 9, 56, 15, 721, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 9, 56, 15, 725, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "DepartmentInformation",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsActive", "Name", "SchoolId" },
                values: new object[] { 1, 1, new DateTime(2021, 2, 8, 9, 56, 15, 737, DateTimeKind.Local), "New test department added", true, "Urdu", 1 });

            migrationBuilder.UpdateData(
                table: "EmployeeInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateofBirth" },
                values: new object[] { new DateTime(2021, 2, 8, 9, 56, 15, 738, DateTimeKind.Local), new DateTime(2021, 2, 8, 9, 56, 15, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExamInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 9, 56, 15, 732, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 9, 56, 15, 720, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 8, 9, 56, 15, 716, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInformation_CreatedBy",
                table: "DepartmentInformation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInformation_SchoolId",
                table: "DepartmentInformation",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentInformation");

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
    }
}
