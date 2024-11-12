using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TP03SWII6.Models;

// CB3021521 - Gabriel Martins Alves da Silva

namespace TP03SWII6
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
