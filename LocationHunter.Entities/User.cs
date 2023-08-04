using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocationHunter.Entities
{
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(50)]
        [Required]
        public string? firstName { get; set; }
        [Required]
        [StringLength(50)]
        public string? lastName { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? password { get; set; }

        public string biography { get; set; } = string.Empty;

    }
}