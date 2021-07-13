using Microsoft.EntityFrameworkCore.Migrations;

namespace PrsWebApi.Migrations
{
    public partial class madecolumnsunique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductNumber",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                table: "Products",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_Code",
                table: "Vendors",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PartNumber",
                table: "Products",
                column: "PartNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vendors_Code",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Products_PartNumber",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProductNumber",
                table: "Products",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
