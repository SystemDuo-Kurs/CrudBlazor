using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudBlazor.Server.Migrations
{
    public partial class Druga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Godiste",
                table: "Osobas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Godiste",
                table: "Osobas");
        }
    }
}
