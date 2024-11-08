using CoffeeShop.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Database.Context;

public class CoffeeAppDbContext : DbContext
{
    public CoffeeAppDbContext(DbContextOptions<CoffeeAppDbContext> options) : base(options) { }

    public DbSet<Coffee> Coffees { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coffee>()
            .ToTable("Coffees")
            .HasKey(c => c.Id);

        modelBuilder.Entity<Coffee>()
            .HasMany(c => c.Reviews)
            .WithOne(r => r.Coffee)
            .HasForeignKey(r => r.CoffeeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Review>()
            .ToTable("Reviews")
            .HasKey(r => r.Id);

        base.OnModelCreating(modelBuilder);
    }
}