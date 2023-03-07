using APIProduct.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProduct.Data
{

    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}