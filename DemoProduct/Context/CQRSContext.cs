using DemoProduct.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProduct.Context
{
    public class CQRSContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-58A8LDS\\SQLEXPRESS; initial catalog=DbCORSDemo;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
