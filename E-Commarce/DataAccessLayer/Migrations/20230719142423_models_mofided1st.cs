using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class models_mofided1st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cart_Itemsid",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "categoryid",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "img_url",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "inventoryid",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "cat_url",
                table: "Product_Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Cart_Itemsid",
                table: "Products",
                column: "Cart_Itemsid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryid",
                table: "Products",
                column: "categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_inventoryid",
                table: "Products",
                column: "inventoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Cart_Items_Cart_Itemsid",
                table: "Products",
                column: "Cart_Itemsid",
                principalTable: "Cart_Items",
                principalColumn: "id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Cart_Items_Cart_Itemsid",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Product_Categories_categoryid",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Product_Inventoru_inventoryid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Cart_Itemsid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_categoryid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_inventoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Cart_Itemsid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "categoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "img_url",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "inventoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "cat_url",
                table: "Product_Categories");
        }
    }
}
