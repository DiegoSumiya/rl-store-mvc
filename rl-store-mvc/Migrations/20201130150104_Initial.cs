using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesManagementMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    PaymentForm = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
