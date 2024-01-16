using Microsoft.EntityFrameworkCore;
using RoleBased.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your entity relationships, keys, etc. here if needed
        // For example, if you have a many-to-many relationship between User and Role:
        modelBuilder.Entity<User>()
            .HasMany(u => u.Roles)
            .WithMany(r => r.Users)
            .UsingEntity(j => j.ToTable("UserRoles"));
    }
}
