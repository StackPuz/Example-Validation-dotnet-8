using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class User
    {
        [Required]
        public int? Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }
        [RegularExpression(@"^\S+@\S+\.\S+$")]
        public string Email { get; set; }
        [Range(1, 100)]
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}