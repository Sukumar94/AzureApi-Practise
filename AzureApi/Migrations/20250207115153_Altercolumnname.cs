using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureApi.Migrations
{
    /// <inheritdoc />
    public partial class Altercolumnname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoanType",
                table: "Loans",
                newName: "loanType");

            migrationBuilder.RenameColumn(
                name: "InterestRate",
                table: "Loans",
                newName: "interestRate");

            migrationBuilder.RenameColumn(
                name: "BorrowerName",
                table: "Loans",
                newName: "borrowerName");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Loans",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Loans",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Term",
                table: "Loans",
                newName: "termMonths");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "loanType",
                table: "Loans",
                newName: "LoanType");

            migrationBuilder.RenameColumn(
                name: "interestRate",
                table: "Loans",
                newName: "InterestRate");

            migrationBuilder.RenameColumn(
                name: "borrowerName",
                table: "Loans",
                newName: "BorrowerName");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Loans",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Loans",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "termMonths",
                table: "Loans",
                newName: "Term");
        }
    }
}
