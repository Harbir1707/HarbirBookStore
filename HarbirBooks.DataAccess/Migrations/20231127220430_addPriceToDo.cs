using Microsoft.EntityFrameworkCore.Migrations;

namespace HarbirBooks.DataAccess.Migrations
{
    public partial class addPriceToDo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ListPrice",
                table: "Products",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "ListPrice");
        }
    }
}
