using project1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITIProject.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Grade { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }

        public virtual Department Department { get; set; }
    }
}