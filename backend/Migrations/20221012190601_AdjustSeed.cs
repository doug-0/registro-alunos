using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class AdjustSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 1,
                column: "CPF",
                value: "999.888.777-66");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 2,
                column: "CPF",
                value: "555.333.222-11");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 3,
                column: "CPF",
                value: "111.222.444-55");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 4,
                column: "CPF",
                value: "333.222.888-66");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 5,
                column: "CPF",
                value: "444.333.009-88");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 1,
                column: "CPF",
                value: "999.888.777.66");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 2,
                column: "CPF",
                value: "555.333.222.11");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 3,
                column: "CPF",
                value: "111.222.444.55");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 4,
                column: "CPF",
                value: "333.222.888.66");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 5,
                column: "CPF",
                value: "444.333.009.88");
        }
    }
}
