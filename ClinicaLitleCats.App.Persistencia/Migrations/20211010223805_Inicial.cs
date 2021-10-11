using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaLitleCats.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentoIdentidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaborales = table.Column<int>(type: "int", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroRethus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tratamiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHoraTratamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tratamiento_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacienteCats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropietarioEncargadoId = table.Column<int>(type: "int", nullable: true),
                    AuxiliarVeterinarioId = table.Column<int>(type: "int", nullable: true),
                    MedicoVeterinarioId = table.Column<int>(type: "int", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacienteCats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacienteCats_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PacienteCats_Personas_AuxiliarVeterinarioId",
                        column: x => x.AuxiliarVeterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PacienteCats_Personas_MedicoVeterinarioId",
                        column: x => x.MedicoVeterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PacienteCats_Personas_PropietarioEncargadoId",
                        column: x => x.PropietarioEncargadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Signo = table.Column<int>(type: "int", nullable: false),
                    PacienteCatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignosVitales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignosVitales_PacienteCats_PacienteCatId",
                        column: x => x.PacienteCatId,
                        principalTable: "PacienteCats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PacienteCats_AuxiliarVeterinarioId",
                table: "PacienteCats",
                column: "AuxiliarVeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteCats_HistoriaId",
                table: "PacienteCats",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteCats_MedicoVeterinarioId",
                table: "PacienteCats",
                column: "MedicoVeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteCats_PropietarioEncargadoId",
                table: "PacienteCats",
                column: "PropietarioEncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_PacienteCatId",
                table: "SignosVitales",
                column: "PacienteCatId");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamiento_HistoriaId",
                table: "Tratamiento",
                column: "HistoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignosVitales");

            migrationBuilder.DropTable(
                name: "Tratamiento");

            migrationBuilder.DropTable(
                name: "PacienteCats");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
