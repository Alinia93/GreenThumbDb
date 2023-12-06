using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumbDb.Models
{
    public class Plant
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("english_name")]
        public string EnglishName { get; set; } = null!;
        [Column("botanical_name")]
        public string? BotanicalName { get; set; }
        [Column("family")]
        public string? Family { get; set; }

        [Column("color")]
        public string? Color { get; set; }
        [Column("image_url")]
        public string? ImageUrl { get; set; }

        public List<Instruction> Instructions { get; set; } = new();
        public List<GardenPlants> GardenPlants { get; set; } = new();
    }
}
