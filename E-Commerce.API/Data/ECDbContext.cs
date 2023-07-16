using E_Commerce.API.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.API.Data
{
    public class ECDbContext : DbContext
    {
        public ECDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
