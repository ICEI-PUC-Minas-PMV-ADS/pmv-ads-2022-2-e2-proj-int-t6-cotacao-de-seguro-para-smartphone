using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguroCelular.Mvc.Migrations.AppDb
{
    public partial class CorrigirTabelaAvaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_CotacaoSeguro_CotacaoSeguroId",
                table: "Avaliacoes");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacoes_CotacaoSeguroId",
                table: "Avaliacoes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_CotacaoSeguroId",
                table: "Avaliacoes",
                column: "CotacaoSeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_CotacaoSeguro_CotacaoSeguroId",
                table: "Avaliacoes",
                column: "CotacaoSeguroId",
                principalTable: "CotacaoSeguro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
