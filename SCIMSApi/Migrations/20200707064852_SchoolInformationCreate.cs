using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class SchoolInformationCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserInformations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserInformations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "SchoolInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    RegistrationNo = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolInformation_UserInformations_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SchoolInformation",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "IsActive", "Logo", "Mobile", "Name", "Phone", "RegistrationNo" },
                values: new object[] { 1, "Abu Dhabi, UAE", 1, new DateTime(2020, 7, 7, 10, 48, 52, 272, DateTimeKind.Local), true, "this.png", "91 45454655", "Test School One", "0302 45454555", "011121110" });

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive" },
                values: new object[] { new DateTime(2020, 7, 7, 10, 48, 52, 269, DateTimeKind.Local), true });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInformation_CreatedBy",
                table: "SchoolInformation",
                column: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolInformation");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserInformations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserInformations");
        }
    }
}
