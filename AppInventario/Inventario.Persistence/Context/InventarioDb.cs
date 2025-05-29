using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Domain.Entities;

namespace Inventario.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=VICTORFDJ;Database=DB_Inventario;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>(entity =>
            {
                entity.Property(e => e.Precio)
                      .HasColumnType("decimal(10,2)"); 
            });
        }
    }
}
