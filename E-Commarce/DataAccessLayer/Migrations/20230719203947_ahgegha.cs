using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ahgegha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_discountid",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Product_Categories_categoryid",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Product_Inventoru_inventoryid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_categoryid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_discountid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_inventoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "categoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "discount_id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "discountid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "inventory_id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "inventoryid",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Product_Categoryid",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Product_Categoryid",
                table: "Products",
                column: "Product_Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Product_Categories_Product_Categoryid",
                table: "Products",
                column: "Product_Categoryid",
                principalTable: "Product_Categories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Product_Categories_Product_Categoryid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Product_Categoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_Categoryid",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "categoryid",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "discount_id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "discountid",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "inventory_id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "inventoryid",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryid",
                table: "Products",
                column: "categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_discountid",
                table: "Products",
                column: "discountid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_inventoryid",
                table: "Products",
                column: "inventoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Discounts_discountid",
                table: "Products",
                column: "discountid",
                principalTable: "Discounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Product_Categories_categoryid",
                table: "Products",
                column: "categoryid",
                principalTable: "Product_Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Product_Inventoru_inventoryid",
                table: "Products",
                column: "inventoryid",
                principalTable: "Product_Inventoru",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
