using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class StudentInformationCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ContactNumber = table.Column<string>(nullable: true),
                    EmergencyContact = table.Column<string>(nullable: true),
                    Descriptions = table.Column<string>(maxLength: 500, nullable: true),
                    SchoolId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentInformations_UserInformations_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentInformations_SchoolInformations_SchoolId",
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
                value: new DateTime(2020, 7, 8, 16, 10, 4, 160, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 8, 16, 10, 4, 163, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 8, 16, 10, 4, 160, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "StudentInformations",
                columns: new[] { "Id", "ContactNumber", "CreatedBy", "Descriptions", "EmergencyContact", "Name", "SchoolId" },
                values: new object[] { 1, "1313213", 1, "this is first test student from seeds", "13211313", "Test Student Name", 1 });

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 8, 16, 10, 4, 157, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_StudentInformations_CreatedBy",
                table: "StudentInformations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInformations_SchoolId",
                table: "StudentInformations",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentInformations");

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 8, 12, 22, 47, 938, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 8, 12, 22, 47, 941, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 8, 12, 22, 47, 937, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 8, 12, 22, 47, 934, DateTimeKind.Local));
        }
    }
}
