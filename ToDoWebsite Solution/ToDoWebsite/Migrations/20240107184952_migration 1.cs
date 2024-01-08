using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoWebsite.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "tasks");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "tasks",
                newName: "DeadLine");

            migrationBuilder.AddColumn<bool>(
                name: "important",
                table: "tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "urgent",
                table: "tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "important",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "title",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "urgent",
                table: "tasks");

            migrationBuilder.RenameColumn(
                name: "DeadLine",
                table: "tasks",
                newName: "Created");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
