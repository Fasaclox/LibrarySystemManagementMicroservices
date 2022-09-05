using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LSMBindingMicroserviceApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bindngs",
                columns: table => new
                {
                    Binding_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Binding_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bindngs", x => x.Binding_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bindngs");
        }
    }
}
