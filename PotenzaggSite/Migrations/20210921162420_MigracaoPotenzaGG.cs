using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PotenzaggSite.Migrations
{
    public partial class MigracaoPotenzaGG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comunidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComunidadeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comunidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comunidades_Comunidades_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InteresseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interesses_Interesses_InteresseId",
                        column: x => x.InteresseId,
                        principalTable: "Interesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RedeSocials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedeSocialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedeSocials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedeSocials_RedeSocials_RedeSocialId",
                        column: x => x.RedeSocialId,
                        principalTable: "RedeSocials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SexoUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Orientacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SexoUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nick = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OrientacaoSexual = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OndeConheceu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Campanha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Entrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlTAG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptInEmail = table.Column<bool>(type: "bit", nullable: false),
                    OptInZap = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comunidades_ComunidadeId",
                table: "Comunidades",
                column: "ComunidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interesses_InteresseId",
                table: "Interesses",
                column: "InteresseId");

            migrationBuilder.CreateIndex(
                name: "IX_RedeSocials_RedeSocialId",
                table: "RedeSocials",
                column: "RedeSocialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comunidades");

            migrationBuilder.DropTable(
                name: "Interesses");

            migrationBuilder.DropTable(
                name: "RedeSocials");

            migrationBuilder.DropTable(
                name: "SexoUsuarios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
