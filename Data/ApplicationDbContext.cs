using FoodStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
    }
}
