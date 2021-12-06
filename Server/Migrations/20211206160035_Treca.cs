using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudBlazor.Server.Migrations
{
    public partial class Treca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Godiste",
                table: "Osobas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Godiste",
                table: "Osobas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
