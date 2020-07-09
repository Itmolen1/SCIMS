using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCIMSApi.Migrations
{
    public partial class CourseClassRoomCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseClassRooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassRoomId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseClassRooms", x => new { x.CourseId, x.ClassRoomId });
                    table.UniqueConstraint("AK_CourseClassRooms_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseClassRooms_ClassRoomInformations_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "ClassRoomInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseClassRooms_CoursesInformations_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CoursesInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ClassRoomInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 9, 11, 0, 49, 733, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "CourseClassRooms",
                columns: new[] { "CourseId", "ClassRoomId", "Id", "IsActive" },
                values: new object[] { 1, 1, 1, true });

            migrationBuilder.UpdateData(
                table: "CoursesInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 9, 11, 0, 49, 736, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "SchoolInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 9, 11, 0, 49, 733, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 9, 11, 0, 49, 730, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_CourseClassRooms_ClassRoomId",
                table: "CourseClassRooms",
                column: "ClassRoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseClassRooms");

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

            migrationBuilder.UpdateData(
                table: "UserInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 7, 8, 16, 10, 4, 157, DateTimeKind.Local));
        }
    }
}
