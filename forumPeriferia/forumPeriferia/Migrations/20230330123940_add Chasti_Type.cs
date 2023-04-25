using Microsoft.EntityFrameworkCore.Migrations;

namespace forumPeriferia.Migrations
{
    public partial class addChasti_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "PeriferniChasti",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "PeriferniChasti");
        }
    }
}
