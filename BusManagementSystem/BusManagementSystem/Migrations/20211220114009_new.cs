using Microsoft.EntityFrameworkCore.Migrations;

namespace BusManagementSystem.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Admins");

            migrationBuilder.AddColumn<string>(
                name: "NextOfKin",
                table: "Drivers",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NextOfKin",
                table: "Drivers");

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
