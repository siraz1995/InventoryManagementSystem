using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagementSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId1",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryId1",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CountryId1",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Cities");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId1",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId1",
                table: "Cities",
                column: "CountryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId1",
                table: "Cities",
                column: "CountryId1",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
