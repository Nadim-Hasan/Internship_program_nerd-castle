using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class product_modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "img_url",
                table: "Products",
                newName: "product_img_url");

            migrationBuilder.RenameColumn(
                name: "cat_url",
                table: "Product_Categories",
                newName: "cat_img_url");

            migrationBuilder.AddColumn<int>(
                name: "discountid",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_discountid",
                table: "Products",
                column: "discountid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Discounts_discountid",
                table: "Products",
                column: "discountid",
                principalTable: "Discounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_discountid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_discountid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "discountid",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "product_img_url",
                table: "Products",
                newName: "img_url");

            migrationBuilder.RenameColumn(
                name: "cat_img_url",
                table: "Product_Categories",
                newName: "cat_url");
        }
    }
}
