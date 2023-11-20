using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RostrosFelices.Migrations
{
    /// <inheritdoc />
    public partial class Correpcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_ClienteId",
                table: "Servicios",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Clientes_ClienteId",
                table: "Servicios",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Clientes_ClienteId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_ClienteId",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Servicios");
        }
    }
}
