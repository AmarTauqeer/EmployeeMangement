using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeMangement.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeModelchanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeetId",
                table: "Employees",
                newName: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "EmployeetId");
        }
    }
}
