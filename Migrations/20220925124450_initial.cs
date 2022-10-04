using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagementSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Cities",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cities",
                newName: "CountryId");
        }
    }
}
