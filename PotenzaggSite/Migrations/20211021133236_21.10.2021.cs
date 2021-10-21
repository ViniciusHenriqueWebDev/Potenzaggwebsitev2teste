using Microsoft.EntityFrameworkCore.Migrations;

namespace PotenzaggSite.Migrations
{
    public partial class _21102021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comunidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comunidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComunidadeId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comunidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comunidade_Comunidade_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comunidade_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comunidade_ComunidadeId",
                table: "Comunidade",
                column: "ComunidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comunidade_UsuarioId",
                table: "Comunidade",
                column: "UsuarioId");
        }
    }
}
