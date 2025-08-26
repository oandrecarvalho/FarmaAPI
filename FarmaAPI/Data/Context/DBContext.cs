using FarmaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmaAPI.Data.Context;


public partial class Context : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    
    public Context(DbContextOptions<Context> options) : base(options) { }

    public override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasKey(product => product.Id);
        
        modelBuilder.Entity<Client>()
            .HasKey(client => client.Id);
        
        modelBuilder.Entity<Sale>()
            .HasKey(sale => sale.Id)
        
        OnModelCreatingPartial(modelBuilder);
    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}