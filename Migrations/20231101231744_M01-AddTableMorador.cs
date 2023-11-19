using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arpagen.Migrations
{
    public partial class M01AddTableMorador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlApartamento = table.Column<int>(type: "int", nullable: false),
                    NmApartamento = table.Column<int>(type: "int", nullable: false),
                    Veículo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moradores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moradores");
        }
    }
}
