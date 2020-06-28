using Microsoft.EntityFrameworkCore.Migrations;

namespace Drinkr.Migrations
{
    public partial class DrinkrNewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Motorista",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Motorista");
        }
    }
}
