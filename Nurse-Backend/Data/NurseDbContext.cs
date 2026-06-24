using Microsoft.EntityFrameworkCore;
using Nurse_Backend.Entities;

namespace Nurse_Backend.Data;

//creates table on database migrate

public class NurseDbContext(DbContextOptions<NurseDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}