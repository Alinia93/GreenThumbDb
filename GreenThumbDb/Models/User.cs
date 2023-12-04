using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumbDb.Models
{
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("user_name")]
        public string UserName { get; set; } = null!;
        [Column("password")]
        public string Password { get; set; } = null!;

        [Column("garden")]
        public int GardenId { get; set; }
        public Garden Garden { get; set; } = null!;
    }
}

