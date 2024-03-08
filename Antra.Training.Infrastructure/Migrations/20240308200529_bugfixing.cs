using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.Training.Infrastructure.Migrations
{
    public partial class bugfixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(50)",
                table: "Employees",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "varchar(50)");
        }
    }
}
