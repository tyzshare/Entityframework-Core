using Microsoft.EntityFrameworkCore.Migrations;

namespace Myth.SIS.BurialPoint.Api.Migrations
{
    public partial class Update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookRepos",
                table: "BookRepos");

            migrationBuilder.RenameTable(
                name: "BookRepos",
                newName: "books");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "books",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "BookRepos");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BookRepos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookRepos",
                table: "BookRepos",
                column: "Id");
        }
    }
}
