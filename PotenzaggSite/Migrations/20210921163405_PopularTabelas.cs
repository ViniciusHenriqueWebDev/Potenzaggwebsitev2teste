using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PotenzaggSite.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuarios(Nome,Nick,Email,Celular,DataNascimento,Curso,OptInEmail,OptInZap) VALUES('Vinicius','vhDzN','teste@potenza.gg','11994896585','2000-08-10','LiveForStream','1','1')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Usuario");
        }
    }
}
