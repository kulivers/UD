using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UD.Api.Migrations
{
    public partial class tablesrenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "MockEmployees");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "MockCompanies");

            migrationBuilder.AddColumn<Guid>(
                name: "MockCompanyId",
                table: "MockEmployees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MockEmployees",
                table: "MockEmployees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MockCompanies",
                table: "MockCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MockEmployees_MockCompanyId",
                table: "MockEmployees",
                column: "MockCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_MockEmployees_MockCompanies_MockCompanyId",
                table: "MockEmployees",
                column: "MockCompanyId",
                principalTable: "MockCompanies",
                principalColumn: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MockEmployees_MockCompanies_MockCompanyId",
                table: "MockEmployees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MockEmployees",
                table: "MockEmployees");

            migrationBuilder.DropIndex(
                name: "IX_MockEmployees_MockCompanyId",
                table: "MockEmployees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MockCompanies",
                table: "MockCompanies");

            migrationBuilder.DropColumn(
                name: "MockCompanyId",
                table: "MockEmployees");

            migrationBuilder.RenameTable(
                name: "MockEmployees",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "MockCompanies",
                newName: "Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
