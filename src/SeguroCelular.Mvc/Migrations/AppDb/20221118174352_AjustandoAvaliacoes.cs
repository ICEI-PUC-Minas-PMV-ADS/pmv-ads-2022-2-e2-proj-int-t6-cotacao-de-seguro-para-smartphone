using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguroCelular.Mvc.Migrations.AppDb
{
    public partial class AjustandoAvaliacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CotacaoSeguroId",
                table: "Avaliacoes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CotacaoSeguroId",
                table: "Avaliacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
