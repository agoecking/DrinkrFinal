using Microsoft.EntityFrameworkCore.Migrations;

namespace Drinkr.Migrations
{
    public partial class MigrationCorrida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Local",
                table: "Corrida");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Corrida");

            migrationBuilder.AddColumn<int>(
                name: "MotoristaId",
                table: "Corrida",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origem",
                table: "Corrida",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Corrida_MotoristaId",
                table: "Corrida",
                column: "MotoristaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Corrida_Motorista_MotoristaId",
                table: "Corrida",
                column: "MotoristaId",
                principalTable: "Motorista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corrida_Motorista_MotoristaId",
                table: "Corrida");

            migrationBuilder.DropIndex(
                name: "IX_Corrida_MotoristaId",
                table: "Corrida");

            migrationBuilder.DropColumn(
                name: "MotoristaId",
                table: "Corrida");

            migrationBuilder.DropColumn(
                name: "Origem",
                table: "Corrida");

            migrationBuilder.AddColumn<string>(
                name: "Local",
                table: "Corrida",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Corrida",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
