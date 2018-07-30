using Microsoft.EntityFrameworkCore.Migrations;

namespace Myth.SIS.BurialPoint.Api.Migrations
{
    public partial class Update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_bookaas",
                table: "bookaas");

            migrationBuilder.RenameTable(
                name: "bookaas",
                newName: "bookaasaaaaa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookaasaaaaa",
                table: "bookaasaaaaa",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_bookaasaaaaa",
                table: "bookaasaaaaa");

            migrationBuilder.RenameTable(
                name: "bookaasaaaaa",
                newName: "bookaas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookaas",
                table: "bookaas",
                column: "Id");
        }
    }
}
