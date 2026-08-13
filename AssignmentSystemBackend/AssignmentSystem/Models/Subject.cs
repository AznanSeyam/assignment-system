using System.ComponentModel.DataAnnotations;

namespace AssignmentSystemBackend.Models
{
    public class Subject
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, MaxLength(100)]
        public string SubjectName { get; set; } = string.Empty; // e.g., "Mathematics"

        // Navigation Properties
        public ICollection<TeacherClassSubject> TeacherClassSubjects { get; set; } = new List<TeacherClassSubject>();
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
    }
}