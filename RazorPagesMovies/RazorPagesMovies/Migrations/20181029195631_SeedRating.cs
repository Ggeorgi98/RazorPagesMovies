using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovies.Migrations
{
    public partial class SeedRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 1,
                column: "Rating",
                value: "R");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 2,
                column: "Rating",
                value: "R");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 3,
                column: "Rating",
                value: "R");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 4,
                column: "Rating",
                value: "R");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 1,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 2,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 3,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 4,
                column: "Rating",
                value: null);
        }
    }
}
