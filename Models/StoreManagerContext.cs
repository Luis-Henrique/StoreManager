using Microsoft.EntityFrameworkCore;

namespace StoreManager.Models;

public class StoreManagerContext : DbContext
{
    public DbSet<Clients>? Clients { get; set; }
    public DbSet<Collaborators>? Collaborators { get; set; }
    public DbSet<Inventories>? Inventories { get; set; }
    public DbSet<Products>? Products { get; set; }
    public DbSet<Stores>? Stores { get; set; }
    public DbSet<Providers>? Providers { get; set; }
    
    public StoreManagerContext(DbContextOptions<StoreManagerContext> options) : base(options)
    {
        
    }
}