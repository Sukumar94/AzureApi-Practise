using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureApi.Migrations
{
    /// <inheritdoc />
    public partial class Addedtwofields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Loans");

            migrationBuilder.AddColumn<string>(
                name: "LoanType",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Term",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanType",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Loans");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Loans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
