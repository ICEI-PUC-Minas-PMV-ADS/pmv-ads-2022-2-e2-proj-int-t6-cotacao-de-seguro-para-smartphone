using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguroCelular.Mvc.Migrations.AppDb
{
    public partial class AddFkInCotacaoSeguro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CotacaoSeguro_Users_CotacaoSeguroId",
                table: "CotacaoSeguro");

            migrationBuilder.DropIndex(
                name: "IX_CotacaoSeguro_CotacaoSeguroId",
                table: "CotacaoSeguro");

            migrationBuilder.DropColumn(
                name: "CotacaoSeguroId",
                table: "CotacaoSeguro");

            migrationBuilder.CreateIndex(
                name: "IX_CotacaoSeguro_UserId",
                table: "CotacaoSeguro",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CotacaoSeguro_Users_UserId",
                table: "CotacaoSeguro",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CotacaoSeguro_Users_UserId",
                table: "CotacaoSeguro");

            migrationBuilder.DropIndex(
                name: "IX_CotacaoSeguro_UserId",
                table: "CotacaoSeguro");

            migrationBuilder.AddColumn<int>(
                name: "CotacaoSeguroId",
                table: "CotacaoSeguro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CotacaoSeguro_CotacaoSeguroId",
                table: "CotacaoSeguro",
                column: "CotacaoSeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_CotacaoSeguro_Users_CotacaoSeguroId",
                table: "CotacaoSeguro",
                column: "CotacaoSeguroId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
