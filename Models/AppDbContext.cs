using ControlGastosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlGastosAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Gasto> Gastos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gasto>()
                .Property(g => g.Monto)
                .HasPrecision(10, 2);
        }
    }
}
