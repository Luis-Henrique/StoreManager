using Microsoft.EntityFrameworkCore;

namespace StoreManager.Models;

public class StoreManagerContext : DbContext
{
    public DbSet<Clients>? Clients { get; set; }
    public DbSet<Collaborators>? Collaborators { get; set; }
    public DbSet<Inventories>? Inventories { get; set; }
    public DbSet<Products>? product { get; set; }
    public DbSet<Stores>? Store { get; set; }
    public DbSet<Providers>? Provider { get; set; }
    
    public StoreManagerContext(DbContextOptions<StoreManagerContext> options) : base(options)
    {
        
    }
}