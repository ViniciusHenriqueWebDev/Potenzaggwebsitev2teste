using Microsoft.EntityFrameworkCore.Migrations;

namespace PotenzaggSite.Migrations
{
    public partial class _22102021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mensagem",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Embaixador",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreamerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspiracaoStreamer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeloStreamer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraStream = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embaixador", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Embaixador");

            migrationBuilder.DropColumn(
                name: "Mensagem",
                table: "Usuarios");
        }
    }
}
