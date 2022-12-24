using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vaccins_CentreVaccination_CentreVaccinationId",
                table: "vaccins");

            migrationBuilder.RenameColumn(
                name: "CentreVaccinationId",
                table: "vaccins",
                newName: "CentreVaccinationFK");

            migrationBuilder.RenameIndex(
                name: "IX_vaccins_CentreVaccinationId",
                table: "vaccins",
                newName: "IX_vaccins_CentreVaccinationFK");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "CentreVaccination",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_vaccins_CentreVaccination_CentreVaccinationFK",
                table: "vaccins",
                column: "CentreVaccinationFK",
                principalTable: "CentreVaccination",
                principalColumn: "CentreVaccinationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vaccins_CentreVaccination_CentreVaccinationFK",
                table: "vaccins");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "CentreVaccination");

            migrationBuilder.RenameColumn(
                name: "CentreVaccinationFK",
                table: "vaccins",
                newName: "CentreVaccinationId");

            migrationBuilder.RenameIndex(
                name: "IX_vaccins_CentreVaccinationFK",
                table: "vaccins",
                newName: "IX_vaccins_CentreVaccinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_vaccins_CentreVaccination_CentreVaccinationId",
                table: "vaccins",
                column: "CentreVaccinationId",
                principalTable: "CentreVaccination",
                principalColumn: "CentreVaccinationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
