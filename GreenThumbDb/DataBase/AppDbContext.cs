using GreenThumbDb.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbDb.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public DbSet<Garden> Gardens { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<GardenPlants> GardenPlants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GreenThumbDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GardenPlants>().HasKey(gp => new { gp.PlantId, gp.GardenId });
        }
    }
}
