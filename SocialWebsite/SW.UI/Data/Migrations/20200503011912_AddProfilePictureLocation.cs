using Microsoft.EntityFrameworkCore.Migrations;

namespace SW.UI.Migrations
{
    public partial class AddProfilePictureLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureLocation",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureLocation",
                table: "AspNetUsers");
        }
    }
}
