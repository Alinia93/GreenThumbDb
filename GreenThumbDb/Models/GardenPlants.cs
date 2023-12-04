using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumbDb.Models
{
    public class GardenPlants
    {
        [Column("plant_id")]
        public int PlantId { get; set; }
        public Plant Plant { get; set; } = null!;
        [Column("garden_id")]
        public int GardenId { get; set; }
        public Garden Garden { get; set; } = null!;

    }
}
