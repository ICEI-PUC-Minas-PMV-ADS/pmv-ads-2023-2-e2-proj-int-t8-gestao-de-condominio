using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arpagen.Migrations
{
    public partial class M07AddTableAreaComum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreasComun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bloco = table.Column<int>(type: "int", nullable: false),
                    Apartamento = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasComun", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreasComun");
        }
    }
}
