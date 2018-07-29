using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Myth.SIS.BurialPoint.Api.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BookRepos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "BookRepos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "BookRepos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "BookRepos");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BookRepos");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "BookRepos");
        }
    }
}
