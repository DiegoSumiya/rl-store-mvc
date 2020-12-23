using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesManagementMVC.Migrations
{
    public partial class NovoAtributoOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Order");
        }
    }
}
