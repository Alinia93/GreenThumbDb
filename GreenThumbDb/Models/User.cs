using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumbDb.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_name")]
        public string UserName { get; set; } = null!;
        [Column("password")]
        public string Password { get; set; } = null!;

        public Garden? Garden { get; set; }

    }
}

