using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arpagen.Migrations
{
    public partial class M06AddTableVisitantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visitantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF= table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bloco = table.Column<int>(type: "int", nullable: false),
                    Ap = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<int>(type: "int", nullable: false),
                    placaVeiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendamentos", x => x.Id);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitantes");

        }
    }
}
