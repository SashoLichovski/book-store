using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreApi.Data.Migrations
{
    public partial class BookAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "HistoryBooks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "FantasyBooks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "ClassicBooks",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "HistoryBooks");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "FantasyBooks");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "ClassicBooks");
        }
    }
}
