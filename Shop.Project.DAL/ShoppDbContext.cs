using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shob.Project.Models.Entities;
using Shop.Project.DAL.Conficurations;

namespace Shop.Project.DAL;

public class ShoppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Data Source=STHQ0116-01;Initial Catalog = ShoppDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConficuration());
        modelBuilder.ApplyConfiguration(new CategoryConficuration());

    }
}
