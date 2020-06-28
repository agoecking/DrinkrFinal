using Microsoft.EntityFrameworkCore.Migrations;

namespace Drinkr.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Usuario_UsuarioId",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cartao_Usuario_UsuarioId",
                table: "Cartao");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Cartao",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Carro",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Usuario_UsuarioId",
                table: "Carro",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cartao_Usuario_UsuarioId",
                table: "Cartao",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Usuario_UsuarioId",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cartao_Usuario_UsuarioId",
                table: "Cartao");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Cartao",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Carro",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Usuario_UsuarioId",
                table: "Carro",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cartao_Usuario_UsuarioId",
                table: "Cartao",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
