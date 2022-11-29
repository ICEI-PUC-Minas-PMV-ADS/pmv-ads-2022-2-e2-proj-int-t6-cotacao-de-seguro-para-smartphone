using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguroCelular.Mvc.Migrations.AppDb
{
    public partial class AddCampoPlano : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Planos",
                table: "CotacaoSeguro",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Planos",
                table: "CotacaoSeguro");
        }
    }
}
