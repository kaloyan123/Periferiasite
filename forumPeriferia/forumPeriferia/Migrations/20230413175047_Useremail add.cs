using Microsoft.EntityFrameworkCore.Migrations;

namespace forumPeriferia.Migrations
{
    public partial class Useremailadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Useremail",
                table: "AspNetUsers",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Useremail",
                table: "AspNetUsers");
        }
    }
}
