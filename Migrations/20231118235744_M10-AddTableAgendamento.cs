using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arpagen.Migrations
{
    public partial class M10AddTableAgendamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ap",
                table: "Agendamentos",
                newName: "Apartamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apartamento",
                table: "Agendamentos",
                newName: "Ap");
        }
    }
}
