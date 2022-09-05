using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LSMBorrowerMicroserviceApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    Borrower_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    BookISBN_Id = table.Column<int>(type: "int", nullable: false),
                    Is_Borrowed = table.Column<bool>(type: "bit", nullable: false),
                    Date_Borrowed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Expected_Return = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count_Book_Borrowed = table.Column<int>(type: "int", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.Borrower_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowers");
        }
    }
}
