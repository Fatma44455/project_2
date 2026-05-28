using System.ComponentModel.DataAnnotations;

namespace project1.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Manager { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}