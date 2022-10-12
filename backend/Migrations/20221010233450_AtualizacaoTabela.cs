using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class AtualizacaoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "tb_estudantes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_estudantes",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_estudantes",
                table: "tb_estudantes",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_estudantes",
                table: "tb_estudantes");

            migrationBuilder.RenameTable(
                name: "tb_estudantes",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }
    }
}
