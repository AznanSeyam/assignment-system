using System.ComponentModel.DataAnnotations;

namespace AssignmentSystemBackend.Models
{
    public class Class
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, MaxLength(50)]
        public string ClassName { get; set; } = string.Empty; // e.g., "Class 10 - Science"

        // Navigation Properties
        public ICollection<TeacherClassSubject> TeacherClassSubjects { get; set; } = new List<TeacherClassSubject>();
        public ICollection<StudentClass> StudentClasses { get; set; } = new List<StudentClass>();
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
    }
}