using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LSMBookMicroserviceApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookISBN_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Binding_Id = table.Column<int>(type: "int", nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Shelf_Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year_Published = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number_Actual_Copies = table.Column<int>(type: "int", nullable: false),
                    Number_Current_Copies = table.Column<int>(type: "int", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookISBN_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
