using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMovies.Migrations
{
    public partial class RatingAndImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");
        }
    }
}
