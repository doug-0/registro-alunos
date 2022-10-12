using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class UpdateStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RA",
                table: "tb_estudantes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 1,
                column: "RA",
                value: 321);

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 2,
                column: "RA",
                value: 535);

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 3,
                column: "RA",
                value: 987);

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 4,
                column: "RA",
                value: 746);

            migrationBuilder.UpdateData(
                table: "tb_estudantes",
                keyColumn: "id",
                keyValue: 5,
                column: "RA",
                value: 125);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RA",
                table: "tb_estudantes");
        }
    }
}
