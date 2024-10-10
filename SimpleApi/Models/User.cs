using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public required string Name { get; set; }
    }
}
