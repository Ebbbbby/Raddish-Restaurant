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
    }
}
