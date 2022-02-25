using Microsoft.EntityFrameworkCore.Migrations;

namespace BerilliumTask.Migrations
{
    public partial class additional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BtnLink",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BtnText",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BtnLink",
                table: "News");

            migrationBuilder.DropColumn(
                name: "BtnText",
                table: "News");
        }
    }
}
