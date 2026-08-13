using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentSystemBackend.Models
{
    public class Assignment
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required, Range(1, 1000)]
        public int MaxMarks { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public Guid TeacherId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public User Teacher { get; set; } = null!;

        [Required]
        public Guid ClassId { get; set; }
        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; } = null!;

        [Required]
        public Guid SubjectId { get; set; }
        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;

        // Navigation Properties
        public ICollection<Submission> Submissions { get; set; } = new List<Submission>();
    }
}