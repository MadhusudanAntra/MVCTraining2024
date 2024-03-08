using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.Training.Infrastructure.Migrations
{
    public partial class ChangeDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "varchar(50)");

            migrationBuilder.AddColumn<string>(
                name: "varchar(250)",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "varchar(250)",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "varchar(50)",
                table: "Employees",
                newName: "Name");
        }
    }
}
