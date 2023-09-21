using LMSTUDYwebService.Models;
using Microsoft.EntityFrameworkCore;

namespace LMSTUDYwebService.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Formation> Formations { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Panier> Paniers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formation>()
                .HasOne(f => f.Categorie)
                .WithMany()
                .HasForeignKey(f => f.CategorieId);

            modelBuilder.Entity<Formation>()
                .Property(f => f.Price)
                .HasColumnType("decimal(18, 2)"); 
        }

    }
}
