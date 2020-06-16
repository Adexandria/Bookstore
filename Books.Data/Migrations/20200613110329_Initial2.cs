using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BestOfTheWeek",
                table: "Book",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "New",
                table: "Book",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Trendy",
                table: "Book",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Trendy",
                value: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "Trendy",
                value: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "New", "Trendy" },
                values: new object[] { true, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestOfTheWeek",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "New",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Trendy",
                table: "Book");
        }
    }
}
