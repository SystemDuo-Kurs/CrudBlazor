using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudBlazor.Server.Migrations
{
    public partial class Prva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osobas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Osobas",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { -3, "Trecko", "Treckovic" });

            migrationBuilder.InsertData(
                table: "Osobas",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { -2, "Neko", "Nekic" });

            migrationBuilder.InsertData(
                table: "Osobas",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { -1, "Pera", "Peric" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osobas");
        }
    }
}
