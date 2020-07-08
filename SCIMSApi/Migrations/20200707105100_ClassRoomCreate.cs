using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class ClassRoomCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolInformation_UserInformations_CreatedBy",
                table: "SchoolInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolInformation",
                table: "SchoolInformation");

            migrationBuilder.RenameTable(
                name: "SchoolInformation",
                newName: "SchoolInformations");

            migrationBuilder.RenameIndex(
                name: "IX_SchoolInformation_CreatedBy",
                table: "SchoolInformations",
                newName: "IX_SchoolInformations_CreatedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolInformations",
                table: "SchoolInformations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ClassRoomInformations",
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
                    table.PrimaryKey("PK_ClassRoomInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassRoomInformations_UserInformations_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoomInformations_SchoolInformations_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "SchoolInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ClassRoomInformations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsActive", "Name", "SchoolId" },
                values: new object[] { 1, 1, new DateTime(2020, 7, 7, 14, 50, 59, 702, DateTimeKind.Local), "Test Class Room", true, "Class 1", 1 });

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 7, 14, 50, 59, 701, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 7, 14, 50, 59, 698, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoomInformations_CreatedBy",
                table: "ClassRoomInformations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoomInformations_SchoolId",
                table: "ClassRoomInformations",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolInformations_UserInformations_CreatedBy",
                table: "SchoolInformations",
                column: "CreatedBy",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolInformations_UserInformations_CreatedBy",
                table: "SchoolInformations");

            migrationBuilder.DropTable(
                name: "ClassRoomInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolInformations",
                table: "SchoolInformations");

            migrationBuilder.RenameTable(
                name: "SchoolInformations",
                newName: "SchoolInformation");

            migrationBuilder.RenameIndex(
                name: "IX_SchoolInformations_CreatedBy",
                table: "SchoolInformation",
                newName: "IX_SchoolInformation_CreatedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolInformation",
                table: "SchoolInformation",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "SchoolInformation",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 7, 10, 48, 52, 272, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 7, 10, 48, 52, 269, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolInformation_UserInformations_CreatedBy",
                table: "SchoolInformation",
                column: "CreatedBy",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
