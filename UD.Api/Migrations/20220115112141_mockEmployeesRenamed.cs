using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UD.Api.Migrations
{
    public partial class mockEmployeesRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MockEmployees2_MockCompanies_CompanyId",
                table: "MockEmployees2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MockEmployees2",
                table: "MockEmployees2");

            migrationBuilder.RenameTable(
                name: "MockEmployees2",
                newName: "MockEmployees");

            migrationBuilder.RenameIndex(
                name: "IX_MockEmployees2_CompanyId",
                table: "MockEmployees",
                newName: "IX_MockEmployees_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MockEmployees",
                table: "MockEmployees",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MockEmployees_MockCompanies_CompanyId",
                table: "MockEmployees",
                column: "CompanyId",
                principalTable: "MockCompanies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MockEmployees_MockCompanies_CompanyId",
                table: "MockEmployees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MockEmployees",
                table: "MockEmployees");

            migrationBuilder.RenameTable(
                name: "MockEmployees",
                newName: "MockEmployees2");

            migrationBuilder.RenameIndex(
                name: "IX_MockEmployees_CompanyId",
                table: "MockEmployees2",
                newName: "IX_MockEmployees2_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MockEmployees2",
                table: "MockEmployees2",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MockEmployees2_MockCompanies_CompanyId",
                table: "MockEmployees2",
                column: "CompanyId",
                principalTable: "MockCompanies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
