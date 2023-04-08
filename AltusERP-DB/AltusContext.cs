

using AltusERP_DB.Model;
using Microsoft.EntityFrameworkCore;

namespace AltusERP_DB;

public class AltusContext : DbContext
{
    public AltusContext(DbContextOptions<AltusContext> options) : base(options)
    {//s
    }
    //Security
    public DbSet<Rol> Beers { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Rename entities mapping 
        modelBuilder.Entity<Rol>().ToTable("Rol");
        modelBuilder.Entity<User>().ToTable("User");
    }
}