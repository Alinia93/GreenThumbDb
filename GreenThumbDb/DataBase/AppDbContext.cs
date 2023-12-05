using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using GreenThumbDb.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbDb.DataBase
{
    public class AppDbContext : DbContext
    {

        private readonly IEncryptionProvider _encryptionProvider;
        public AppDbContext()
        {

            _encryptionProvider = new GenerateEncryptionProvider("oooooooooooooooooooooooo");
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
                       EnglishName = "Jalapeño",
                       BotanicalName = "Capiscum annuum",
                       Family = "Solanaceae",





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

                       Color = "Blue"




                   }, new Plant()
                   {
                       Id = 15,
                       EnglishName = "Garlic",
                       BotanicalName = "Allium sativum",
                       Family = "Amaryllidaceae",





                   }, new Plant()
                   {
                       Id = 16,
                       EnglishName = "Camellia",
                       BotanicalName = "Camellia",
                       Family = "Theaceae",
                       Color = "White, pink, red, yellow, or lavender"




                   }, new Plant()
                   {
                       Id = 17,
                       EnglishName = "Delphinium, Larkspur",
                       BotanicalName = "Delphinium",
                       Family = "Ranunculaceae",
                       Color = "Pastel, blue, pink, purple, white"




                   }, new Plant()
                   {
                       Id = 18,
                       EnglishName = "Dahlia",
                       BotanicalName = "Dahlia",
                       Family = "Dahlia",
                       Color = "Red, Pink, Orange, Yellow, Purple, White"




                   }, new Plant()
                   {
                       Id = 19,
                       EnglishName = "Dragon tree",
                       BotanicalName = "Dracaena marginata",
                       Family = "Asparagaceae",
                       Color = "White"
                   });

            modelBuilder.Entity<Instruction>().HasData(
            new Instruction()
            {
                Id = 1,
                Name = "Cactus: Light",
                Description = "Cacti require four to six hours of bright sunlight daily. ",
                PlantId = 1,

            },
               new Instruction()
               {
                   Id = 2,
                   Name = "Cactus: Water",
                   Description = "During the spring and summer, give the cactus water every ten days.During the winter rest period, decrease waterings to once every four weeks. ",
                   PlantId = 1

               },
                  new Instruction()
                  {
                      Id = 3,
                      Name = "Nasturtium: Soil",
                      Description = " Nasturtium grows best in soil with a neutral pH (6 to 8) and can tolerate dry conditions, although a moderate amount of moisture is appreciated. ",
                      PlantId = 2

                  }, new Instruction()
                  {
                      Id = 4,
                      Name = "Nasturium: Water",
                      Description = "Nasturtiums prefer weekly watering, but can be watered more often when planted in a greenhouse or in a sunny vegetable plot",
                      PlantId = 2

                  }, new Instruction()
                  {
                      Id = 5,
                      Name = "Nasturium: Light",
                      Description = "Nasturtiums grow and bloom best when planted in an area of full sun that receives six to eight hours of direct sunlight daily.",
                      PlantId = 2

                  }, new Instruction()
                  {
                      Id = 6,
                      Name = "Tea Olive: Water",
                      Description = "Give your tea olive shrub at least one inch of water per week, either through rainfall or manual watering methods.",
                      PlantId = 4

                  }, new Instruction()
                  {
                      Id = 7,
                      Name = "Rose: Light",
                      Description = "Roses like six hours of sun per day, it does matter what part of the day those six hours come from",
                      PlantId = 3

                  }, new Instruction()
                  {
                      Id = 8,
                      Name = "Rose: Water",
                      Description = "It is best to water roses twice a week—and water them thoroughly. It's better to water deeply twice per week than to water less deeply more often.",
                      PlantId = 3

                  }, new Instruction()
                  {
                      Id = 9,
                      Name = "Rose: Temperature",
                      Description = "Roses can survive periodic weather extremes, but they prefer temperatures between 60 and 70 degrees Fahrenheit and a humidity range between 60% and 70%.",
                      PlantId = 3

                  }, new Instruction()
                  {
                      Id = 10,
                      Name = "Teddy bear Sunflower: Light",
                      Description = "Teddy Bear' sunflower needs full sun; a six to eight hours of bright, direct sunlight daily.",
                      PlantId = 5

                  }, new Instruction()
                  {
                      Id = 11,
                      Name = "Teddy bear Sunflower: Water",
                      Description = "Teddy Bear' sunflowers need one inch of water weekly depending on rainfall amounts and soil conditions. Avoid overwatering as this can lead to root rot and cause stems to become unstable. ",
                      PlantId = 5

                  }, new Instruction()
                  {
                      Id = 12,
                      Name = "Viola: Light",
                      Description = "Violas prefer sun over shade, but they don't like heat.",
                      PlantId = 6

                  }, new Instruction()
                  {
                      Id = 13,
                      Name = "Viola: Soil",
                      Description = "Pansies and the other violas are best grown in humusy, moist soil, such as a peat-based potting mix, or garden soil heavily amended with organic material. ",
                      PlantId = 6

                  }, new Instruction()
                  {
                      Id = 14,
                      Name = "Viola: Water",
                      Description = "Water Viola regularly, but allow the soil to dry out between waterings.",
                      PlantId = 6

                  }, new Instruction()
                  {
                      Id = 15,
                      Name = "Easter Lily: Light",
                      Description = "Easter lilies prefer to grow in full sun to partial shade, with protection from the strong afternoon sun during the heat of the day",
                      PlantId = 7

                  }, new Instruction()
                  {
                      Id = 16,
                      Name = "Easter Lily: Soil",
                      Description = "Easter lily flowers prefer well-drained soil that’s rich in organic matter, although they'll grow in a variety of soil types as long as the drainage is sufficient.",
                      PlantId = 7

                  }, new Instruction()
                  {
                      Id = 17,
                      Name = "Easter Lily: Water",
                      Description = "Easter lilies like evenly moist soil, so whenever the top inch of soil dries out, water the plants until water starts draining from the bottom. Never allow the plants to sit in water, but also don’t let the soil dry out completely.",
                      PlantId = 7

                  }, new Instruction()
                  {
                      Id = 18,
                      Name = "Artichoke: Water",
                      Description = "Artichokes require lots of moisture for best growth. Deeply water artichoke plants at planting time, and water them deeply at least once or twice per week.",
                      PlantId = 8

                  }, new Instruction()
                  {
                      Id = 19,
                      Name = "Artichoke: Soil",
                      Description = "Artichokes prefer sandy, well-drained but fertile soil. A soil pH slightly on the alkaline side is best.",
                      PlantId = 8

                  }, new Instruction()
                  {
                      Id = 20,
                      Name = "Fuschsia: Temperature",
                      Description = "Fuchsias are happiest with temperatures between 55 and 80 degrees Fahrenheit, though some heat-tolerant cultivars will keep their blooms up to 90 degrees Fahrenheit.",
                      PlantId = 9

                  }, new Instruction()
                  {
                      Id = 21,
                      Name = "Fuschsia: Water",
                      Description = "Fuchsias like to be moist but not soggy. They thrive in humidity, so if you live somewhere dry, they are a little more challenging to grow and keep hydrated.",
                      PlantId = 9

                  }, new Instruction()
                  {
                      Id = 22,
                      Name = "Jalapeño: Water",
                      Description = ". Water Jalapeño when the soil feels dry about an inch down, but don't allow the soil to become waterlogged.",
                      PlantId = 10

                  }, new Instruction()
                  {
                      Id = 23,
                      Name = "Jalapeño: Light",
                      Description = "Plant jalapeño peppers in full sun, meaning at least six hours of direct sunlight on most days.",
                      PlantId = 10

                  }, new Instruction()
                  {
                      Id = 24,
                      Name = "Shooting Star: Light",
                      Description = "A site with partial sun is ideal for shooting star plants.",
                      PlantId = 11

                  }, new Instruction()
                  {
                      Id = 25,
                      Name = "Shooting Star: Soil",
                      Description = "Shooting star plants grow and colonize areas of well-draining or sandy loam, although they will tolerate some clay soils.",
                      PlantId = 11

                  }, new Instruction()
                  {
                      Id = 26,
                      Name = "Zebra grass: Water",
                      Description = "Young zebra grass needs regular watering to get established, but a mature specimen will serve as a drought-tolerant ornamental grass.",
                      PlantId = 12

                  }, new Instruction()
                  {
                      Id = 27,
                      Name = "Zebra grass: Light",
                      Description = "Provide full sun for optimal growth. If the plant is in too much shade, the leaf blades can get floppy, but you can provide a stake or even a tomato cage to help prop them upright.",
                      PlantId = 12

                  }, new Instruction()
                  {
                      Id = 28,
                      Name = "Vanilla Bean Orchid: Light",
                      Description = "Vanilla bean orchid grows best in shade, but these plants will tolerate short periods of morning sun with indirect light.",
                      PlantId = 13

                  }, new Instruction()
                  {
                      Id = 29,
                      Name = "Vanilla Bean Orchid: Water",
                      Description = "Watering a vanilla bean orchid means keeping both the growing medium and the wooden trellis structure damp, because the plant is developing \"air roots\" that draw moisture from the air. ",
                      PlantId = 13

                  }, new Instruction()
                  {
                      Id = 30,
                      Name = "Harebell: Light",
                      Description = "The harebell does best when its planted in full sun to partial shade.",
                      PlantId = 14

                  }, new Instruction()
                  {
                      Id = 31,
                      Name = "Harebell: Water",
                      Description = "These wildflowers like deep, infrequent waters that come from natural rainfall. However, newly established plants benefit from frequent watering.",
                      PlantId = 14

                  }, new Instruction()
                  {
                      Id = 32,
                      Name = "Harebell: Soil",
                      Description = "Well-draining soil is crucially important for the harebell. Consistently moist soil can lead to root rot. ",
                      PlantId = 14

                  }, new Instruction()
                  {
                      Id = 33,
                      Name = "Garlic: Light",
                      Description = "While it may be surprising for a plant that grows primarily underground, garlic loves light. To ensure the best chance at growing success, plant your garlic in a spot that receives full sunlight for at least six to eight hours a day.",
                      PlantId = 15

                  }, new Instruction()
                  {
                      Id = 34,
                      Name = "Garlic: Water",
                      Description = "Garlic doesn't have a ton of water requirements. It generally likes its soil moist and should receive around an inch of water per week, with a slight increase if the weather is especially warm. ",
                      PlantId = 15

                  }, new Instruction()
                  {
                      Id = 35,
                      Name = "Camellia: Light",
                      Description = "Camellias thrive in partial shade or in locations that receive dappled sunlight for the entire day, such as the understory beneath tall airy trees.",
                      PlantId = 16

                  }, new Instruction()
                  {
                      Id = 36,
                      Name = "Camellia: Soil",
                      Description = "Camellias require well-drained soil, and an ideal soil pH for camellias is within the 6.0 to 6.5 range—slightly acidic.",
                      PlantId = 16

                  }, new Instruction()
                  {
                      Id = 37,
                      Name = "Camellia: Water",
                      Description = "Twice-a-week watering for a total of one inch of water per week is a good watering schedule. Apply a three-inch layer of mulch to moderate soil temperatures, retain soil moisture, and stifle weeds.",
                      PlantId = 16

                  }, new Instruction()
                  {
                      Id = 38,
                      Name = "Delphinium: Water",
                      Description = "Water regularly especially during hot weather. Keep soil moist but not waterlogged because these plants are vulnerable to crown rot.",
                      PlantId = 17

                  }, new Instruction()
                  {
                      Id = 39,
                      Name = "Delphinium: Light",
                      Description = "Delphiniums put on their best show in plenty of sun, 6 to 8 hours daily. However, this is not a plant that does well in dry heat. A location that offers morning sun with light afternoon shade during hot weather can improve and extend flowering.",
                      PlantId = 17

                  }, new Instruction()
                  {
                      Id = 40,
                      Name = "Dahlia: Water",
                      Description = "Once sprouted, water your dahlias once or twice a week. Make sure to water deeply, as large tubers may be planted six inches deep.",
                      PlantId = 18

                  }
                  , new Instruction()
                  {
                      Id = 41,
                      Name = "Dahlia: Soil",
                      Description = "Dahlias prefer rich, loamy soil with plenty of organic matter that drains well. ",
                      PlantId = 18

                  }
                  , new Instruction()
                  {
                      Id = 42,
                      Name = "Dragon Tree: Water",
                      Description = "Allow the plants to dry between waterings, but not completely. These plants are more susceptible to root rot, so be very careful never to allow them to sit in standing water.",
                      PlantId = 19

                  }
                  , new Instruction()
                  {
                      Id = 43,
                      Name = "Dragon Tree: Soil",
                      Description = "Dragon tree prefers a very loose, well-drained potting mix. A succulent/cactus potting mix can work well; or you can make your own mix by blending fine gravel, peat moss, and leaf humus in equal parts.",
                      PlantId = 19

                  });
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                UserName = "Alinia",
                Password = "password"
            }, new User()
            {
                Id = 2,
                UserName = "user",
                Password = "password"
            });
        }
    }
}
