using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Data.Migrations
{
    public partial class initail4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Detail_DescriptionId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_DescriptionId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "BooksId",
                table: "Detail",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Detail_BooksId",
                table: "Detail",
                column: "BooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Book_BooksId",
                table: "Detail",
                column: "BooksId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Book_BooksId",
                table: "Detail");

            migrationBuilder.DropIndex(
                name: "IX_Detail_BooksId",
                table: "Detail");

            migrationBuilder.DropColumn(
                name: "BooksId",
                table: "Detail");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_DescriptionId",
                table: "Book",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Detail_DescriptionId",
                table: "Book",
                column: "DescriptionId",
                principalTable: "Detail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
