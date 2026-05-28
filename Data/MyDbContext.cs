using ITIProject.Models;
using Microsoft.EntityFrameworkCore;
using project1.Models;
namespace ITIProject.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainee> Trainees { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
    }
}