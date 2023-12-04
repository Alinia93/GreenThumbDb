using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using GreenThumbDb.Managers;
using GreenThumbDb.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbDb.DataBase
{
    public class AppDbContext : DbContext
    {

        private readonly IEncryptionProvider _encryptionProvider;
        public AppDbContext()
        {
            _encryptionProvider = new GenerateEncryptionProvider(KeyManager.GetEncryptionKey());
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

            modelBuilder.UseEncryption(_encryptionProvider);
        }
    }
}
