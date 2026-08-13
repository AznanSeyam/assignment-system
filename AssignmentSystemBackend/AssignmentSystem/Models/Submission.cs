using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentSystemBackend.Models
{
    public class Submission
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid AssignmentId { get; set; }
        [ForeignKey(nameof(AssignmentId))]
        public Assignment Assignment { get; set; } = null!;

        [Required]
        public Guid StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public User Student { get; set; } = null!;

        [Required]
        public string AnswerContent { get; set; } = string.Empty; // Text answer or File/Drive URL

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        public int? ObtainedMarks { get; set; }

        public string? Feedback { get; set; }

        public bool IsGraded { get; set; } = false;

        public DateTime? GradedAt { get; set; }
    }
}