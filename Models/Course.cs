using System.ComponentModel.DataAnnotations;

namespace project1.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Degree { get; set; }

        public int MinDegree { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}