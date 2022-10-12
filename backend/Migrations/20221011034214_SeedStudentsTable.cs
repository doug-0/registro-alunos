using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class SeedStudentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tb_estudantes",
                columns: new[] { "id", "CPF", "Email", "Name", "RA" },
                values: new object[,]
                {
                    { 1, "999.888.777.66", "douglas@email.com", "Douglas Oliveira", "101123" },
                    { 2, "555.333.222.11", "Paula@email.com", "Paula Souza", "101235" },
                    { 3, "111.222.444.55", "jao@email.com", "João Silva", "111687" },
                    { 4, "333.222.888.66", "mari@email.com", "Marina Miranda", "111365" },
                    { 5, "444.333.009.88", "souza@email.com", "Maurício Souza", "101299" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
