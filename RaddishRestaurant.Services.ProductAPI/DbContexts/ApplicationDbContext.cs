using Microsoft.EntityFrameworkCore;
using RaddishRestaurant.Services.ProductAPI.Models;

namespace RaddishRestaurant.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Product>().HasData(new Product
             {
                 ProductId = 1,
                 Name = "Samosa",
                 Price = 15,
                 Description = "Filled with the freshest vegetables and deep fried in olive oil",
                 ImageUrl = "https://images.hindustantimes.com/rf/image_size_630x354/HT/p2/2020/08/02/Pictures/_604f7aa4-d439-11ea-bae0-701c4bed6ede.jpg",
                 CategoryName = "Appetizer"
             });

             modelBuilder.Entity<Product>().HasData(new Product
             {
                 ProductId = 2,
                 Name = "Coconut Rice",
                 Price = 13.99,
                 Description = "Coconut Rice is a delicacy known for its unique and mouth watering taste. Why not give it a try",
                 ImageUrl = "https://www.allnigerianrecipes.com/wp-content/uploads/2019/03/white-coconut-rice.jpg",
                 CategoryName = "Main Dish"

             });

             modelBuilder.Entity<Product>().HasData(new Product
             {
                 ProductId = 3,
                 Name = "Sweet Pie",
                 Price = 7.80,
                 Description = "You can't have a enough of this sweet goodness rolled up in the freshest of dough.",
                 ImageUrl = "https://img.sunset02.com/sites/default/files/styles/4_3_horizontal_inbody_900x506/public/image/2016/10/main/lattice-top-apple-quince-sun-1116_0.jpg",
                 CategoryName = "Appetizer"

             });

             modelBuilder.Entity<Product>().HasData(new Product
             {
                 ProductId = 4,
                 Name = "Chocolate Scoop",
                 Price = 10.99,
                 Description = "Not like the ordinary icecream you come by everyday. Each scoop is filled with creamy goodness",
                 ImageUrl = "https://guardian.ng/wp-content/uploads/2017/07/choclate-icecream1.jpeg",
                 CategoryName="Dessert"
             });

         }
    }
}
