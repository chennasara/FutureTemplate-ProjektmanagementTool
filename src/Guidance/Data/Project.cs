using System.ComponentModel.DataAnnotations;

namespace Guidance.Data
{
    public class Project
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string? Description { get; set; }

        public DateOnly? SubmissionDate { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
