using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Nurse_Backend.Entities;

namespace Nurse_Backend.Data;

//creates table on database migrate

public class NurseDbContext(DbContextOptions<NurseDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(u => u.Username).HasMaxLength(50);
            entity.Property(u => u.PasswordHash).HasMaxLength(255);
            entity.Property(u => u.Roles).HasMaxLength(255);
            entity.Property(u => u.RefreshToken).HasMaxLength(100);
        });
    }
}