using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Movies",
                newName: "EndDate");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Movies",
                newName: "EndTime");
        }
    }
}
