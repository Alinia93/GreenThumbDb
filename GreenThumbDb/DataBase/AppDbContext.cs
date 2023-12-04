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



            //Seeda data 

            modelBuilder.Entity<Plant>().HasData(
                new Plant()
                {
                    Id = 1,
                    EnglishName = "Cactus",
                    BotanicalName = "Cactaceae",
                    Family = "Cactaceae",
                    Color = "Orange, pink, red, yellow, white"




                },
                 new Plant()
                 {
                     Id = 2,
                     EnglishName = "Nasturtium",
                     BotanicalName = "Tropaeolum ",
                     Family = "Tropaeolaceae",
                     Color = "Red, orange, pink, yellow, white"




                 },
                   new Plant()
                   {
                       Id = 3,
                       EnglishName = "Rose",
                       BotanicalName = "Rosa ",
                       Family = "Rosaceae",
                       Color = "White, red, pink, yellow, orange"




                   }, new Plant()
                   {
                       Id = 4,
                       EnglishName = "Tea Olive",
                       BotanicalName = "Osmanthus fragrans",
                       Family = "Oleaceae",
                       Color = "White"




                   }, new Plant()
                   {
                       Id = 5,
                       EnglishName = "Teddy Bear Sunflower",
                       BotanicalName = "Helianthus annuus 'Teddy Bear'",
                       Family = "Asteraceae",
                       Color = "Golden yellow"




                   }, new Plant()
                   {
                       Id = 6,
                       EnglishName = "Viola",
                       BotanicalName = "Viola",
                       Family = "Violaceae",
                       Color = "Purple, orange, white, blue, yellow, red"




                   }, new Plant()
                   {
                       Id = 7,
                       EnglishName = "Easter lily",
                       BotanicalName = "Lilium longiflorum",
                       Family = "Liliaceae",
                       Color = "White, pink"




                   }, new Plant()
                   {
                       Id = 8,
                       EnglishName = "Artichoke",
                       BotanicalName = "Cynara scolymus ",
                       Family = "Asteraceae",
                       Color = "Purple"




                   }, new Plant()
                   {
                       Id = 9,
                       EnglishName = "Fuchsia",
                       BotanicalName = "Fuchsia ",
                       Family = "Onagraceae",
                       Color = "Red, pink, white, violet, purple"




                   }, new Plant()
                   {
                       Id = 10,
                       EnglishName = "",
                       BotanicalName = "",
                       Family = "",
                       Color = ""




                   }, new Plant()
                   {
                       Id = 11,
                       EnglishName = "Shooting star",
                       BotanicalName = "Dodecatheon meadia or Primula meadia",
                       Family = "Primulaceae",
                       Color = "White, pink, purple"




                   }, new Plant()
                   {
                       Id = 12,
                       EnglishName = "Zebra grass",
                       BotanicalName = "Miscanthus sinensis 'Zebrinus",
                       Family = "Poaceae",
                       Color = "Silvery white"




                   }, new Plant()
                   {
                       Id = 13,
                       EnglishName = "Vanilla bean orchid,",
                       BotanicalName = "Vanilla plantifolia",
                       Family = "Orchidaceae",
                       Color = "Yellow-green"




                   }, new Plant()
                   {
                       Id = 14,
                       EnglishName = "Harebells",
                       BotanicalName = "Campanula rotundifolia",
                       Family = "",
                       Color = ""




                   }, new Plant()
                   {
                       Id =
                     EnglishName = "",
                       BotanicalName = "",
                       Family = "",
                       Color = ""




                   }, new Plant()
                   {
                       Id =
                     EnglishName = "",
                       BotanicalName = "",
                       Family = "",
                       Color = ""




                   }, new Plant()
                   {
                       Id =
                     EnglishName = "",
                       BotanicalName = "",
                       Family = "",
                       Color = ""




                   }, new Plant()
                   {
                       Id =
                     EnglishName = "",
                       BotanicalName = "",
                       Family = "",
                       Color = ""




                   }, new Plant()
                   {
                       Id =
                     EnglishName = "",
                       BotanicalName = "",
                       Family = "",
                       Color = ""




                   },




            );
        }
    }
}
