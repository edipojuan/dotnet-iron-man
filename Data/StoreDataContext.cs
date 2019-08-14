using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Data
{
  public class StoreDataContext : DbContext
  {
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseInMemoryDatabase(databaseName: "TesEdipo");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

    }
  }
}
