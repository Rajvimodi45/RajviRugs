using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RajviRugs.Data.Migrations
{
    public partial class Rugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Rugs");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Rugs",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Rugs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Rugs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Rugs");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Rugs");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Rugs",
                newName: "Genre");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Rugs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
