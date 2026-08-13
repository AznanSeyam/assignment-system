using System.ComponentModel.DataAnnotations;

namespace AssignmentSystemBackend.DTOs.Submission
{
    public class SubmitAssignmentDto
    {
        [Required]
        public string AnswerContent { get; set; } = string.Empty;
    }

    public class GradeSubmissionDto
    {
        [Required, Range(0, 1000)]
        public int ObtainedMarks { get; set; }

        public string? Feedback { get; set; }
    }

    public class SubmissionResponseDto
    {
        public Guid SubmissionId { get; set; }
        public Guid AssignmentId { get; set; }
        public string AssignmentTitle { get; set; } = string.Empty;
        public Guid StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string AnswerContent { get; set; } = string.Empty;
        public DateTime SubmittedAt { get; set; }
        public int? ObtainedMarks { get; set; }
        public int MaxMarks { get; set; }
        public string? Feedback { get; set; }
        public bool IsGraded { get; set; }
    }
}