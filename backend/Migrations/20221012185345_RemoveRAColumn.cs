using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class RemoveRAColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RA",
                table: "tb_estudantes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RA",
                table: "tb_estudantes",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 1,
                column: "RA",
                value: "101123");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 2,
                column: "RA",
                value: "101235");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 3,
                column: "RA",
                value: "111687");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 4,
                column: "RA",
                value: "111365");

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 5,
                column: "RA",
                value: "101299");
        }
    }
}
