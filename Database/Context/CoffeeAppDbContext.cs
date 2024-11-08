using CoffeeShop.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Database.Context;

public class CoffeeAppDbContext : DbContext
{
    public CoffeeAppDbContext(DbContextOptions<CoffeeAppDbContext> options) : base(options)
    { }

    public DbSet<Coffee> Coffees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coffee>()
            .ToTable("Coffees")
            .HasKey(r => r.Id);

        base.OnModelCreating(modelBuilder);
    }
}