using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project1.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Imag { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }

        public virtual Department Department { get; set; }

        [ForeignKey("Course")]
        public int Crs_Id { get; set; }

        public virtual Course Course { get; set; }
    }
}