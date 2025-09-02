using System;
using System.Collections.Generic;
using FarmaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace FarmaAPI;

public partial class FarmaDbContext : DbContext
{
    public DbSet<Product> Products;
    public DbSet<Client> Clients;
    public DbSet<Sale> Sales;

    public FarmaDbContext(DbContextOptions<FarmaDbContext> options)
        : base(options)
    {
    }

   
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseMySql("server=localhost;user id=root;password=NapaTheBest@290306$;database=FarmaAPI;port=8889", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.40-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Product>()
            .HasKey(p => p.Id);
        
        modelBuilder.Entity<Client>()
            .HasKey(c => c.Id);
        
        modelBuilder.Entity<Sale>()
            .HasKey(s => s.Id);
        
        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Client)
            .WithMany(p => p.Sales)
            .HasForeignKey(p => p.ClientId);
            
        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Product)
            .WithMany(p => p.Sales)
            .HasForeignKey(s => s.ProductId);
        
        base.OnModelCreating(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
