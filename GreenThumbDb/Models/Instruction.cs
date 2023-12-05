using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumbDb.Models
{
    public class Instruction
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = null!;
        [Column("description")]
        [MaxLength(350)]
        public string Description { get; set; } = null!;
        [Column("plant_id")]
        public int PlantId { get; set; }
        public Plant Plant { get; set; } = null!;
    }
}
