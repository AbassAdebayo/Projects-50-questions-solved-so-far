using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBlog.Migrations
{
    public partial class BB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "postPhoto",
                table: "Posts",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "postPhoto",
                table: "Posts");
        }
    }
}
