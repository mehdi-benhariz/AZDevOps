using Microsoft.EntityFrameworkCore;
using DotNet.Models;

namespace DotNet
{
    public class FestivalContext : DbContext
    {
        public FestivalContext(DbContextOptions<FestivalContext> options)
            : base(options)
        {
        }

        public DbSet<Concert> Concerts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concert>().HasData(
                new Concert
                {
                    Id = 1,
                    Artiste = "Latifa Arfaoui",
                    Date = new DateTime(2024, 7, 15),
                    HeureDebut = new TimeSpan(21, 0, 0),
                    Lieu = "Théâtre antique de Carthage",
                    PrixBillet = 50.00m,
                    PlacesDisponibles = 500,
                    Description = "Concert de musique tunisienne traditionnelle"
                },
                new Concert
                {
                    Id = 2,
                    Artiste = "Saber Rebai",
                    Date = new DateTime(2024, 7, 20),
                    HeureDebut = new TimeSpan(21, 0, 0),
                    Lieu = "Théâtre antique de Carthage",
                    PrixBillet = 60.00m,
                    PlacesDisponibles = 500,
                    Description = "Soirée de musique arabe contemporaine"
                }
            );
        }
    }
}