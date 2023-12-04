using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumbDb.Models
{
    public class Garden
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name)")]
        public string Name { get; set; } = null!;
        [Column("user_id")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public List<GardenPlants> GardenPlants { get; set; } = new();
    }
}
