using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MariemAljeneVaccinBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentreVaccination",
                columns: table => new
                {
                    CentreVaccinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacite = table.Column<int>(type: "int", nullable: false),
                    NbChaise = table.Column<int>(type: "int", nullable: false),
                    NumTelephone = table.Column<int>(type: "int", nullable: false),
                    ResponsableCentre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentreVaccination", x => x.CentreVaccinationId);
                });

            migrationBuilder.CreateTable(
                name: "Citoyen",
                columns: table => new
                {
                    CIN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CodePostal = table.Column<int>(type: "int", nullable: false),
                    Rue = table.Column<int>(type: "int", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroEvax = table.Column<int>(type: "int", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citoyen", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "vaccins",
                columns: table => new
                {
                    VaccinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateValidite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fournisseur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    TypeVaccin = table.Column<int>(type: "int", nullable: false),
                    CentreVaccinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vaccins", x => x.VaccinId);
                    table.ForeignKey(
                        name: "FK_vaccins_CentreVaccination_CentreVaccinationId",
                        column: x => x.CentreVaccinationId,
                        principalTable: "CentreVaccination",
                        principalColumn: "CentreVaccinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RendezVous",
                columns: table => new
                {
                    CitoyenFK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VaccinFK = table.Column<int>(type: "int", nullable: false),
                    CodeInfermiere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateVaccination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NbDoses = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RendezVous", x => new { x.CitoyenFK, x.VaccinFK });
                    table.ForeignKey(
                        name: "FK_RendezVous_Citoyen_CitoyenFK",
                        column: x => x.CitoyenFK,
                        principalTable: "Citoyen",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RendezVous_vaccins_VaccinFK",
                        column: x => x.VaccinFK,
                        principalTable: "vaccins",
                        principalColumn: "VaccinId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RendezVous_VaccinFK",
                table: "RendezVous",
                column: "VaccinFK");

            migrationBuilder.CreateIndex(
                name: "IX_vaccins_CentreVaccinationId",
                table: "vaccins",
                column: "CentreVaccinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RendezVous");

            migrationBuilder.DropTable(
                name: "Citoyen");

            migrationBuilder.DropTable(
                name: "vaccins");

            migrationBuilder.DropTable(
                name: "CentreVaccination");
        }
    }
}
