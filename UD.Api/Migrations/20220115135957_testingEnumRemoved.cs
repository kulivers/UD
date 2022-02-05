using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UD.Api.Migrations
{
    public partial class testingEnumRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Items",
                type: "int",
                nullable: true);
        }
    }
}
