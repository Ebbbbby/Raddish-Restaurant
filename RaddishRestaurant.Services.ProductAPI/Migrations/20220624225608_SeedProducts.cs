using Microsoft.EntityFrameworkCore.Migrations;

namespace RaddishRestaurant.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Filled with the freshest vegetables and deep fried in olive oil", "https://images.hindustantimes.com/rf/image_size_630x354/HT/p2/2020/08/02/Pictures/_604f7aa4-d439-11ea-bae0-701c4bed6ede.jpg", "Samosa", 15.0 },
                    { 2, "Main Dish", "Coconut Rice is a delicacy known for its unique and mouth watering taste. Why not give it a try", "https://www.allnigerianrecipes.com/wp-content/uploads/2019/03/white-coconut-rice.jpg", "Coconut Rice", 13.99 },
                    { 3, "Appetizer", "You can't have a enough of this sweet goodness rolled up in the freshest of dough.", "https://guardian.ng/wp-content/uploads/2017/07/choclate-icecream1.jpeg", "Sweet Pie", 7.7999999999999998 },
                    { 4, "Dessert", "Not like the ordinary icecream you come by everyday. Each scoop is filled with creamy goodness", "", "Chocolate Scoop", 10.99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
