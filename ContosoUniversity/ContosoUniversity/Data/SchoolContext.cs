using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) 
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }

        //"Code like the person following you is an ax weilding murderer and knows where you live"

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable(nameof(Course));
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");

            modelBuilder.Entity<CourseAssignment>().HasKey(y => new { y.CourseID, y.InstructorID });

            modelBuilder.Entity<Department>()
                .Property(p => p.RowVersion).IsConcurrencyToken();

        }

        //"Code like the person following you is an ax weilding murderer and knows where you live"

        public DbSet<ContosoUniversity.Models.Department> Departments { get; set; }
        public DbSet<ContosoUniversity.Models.Instructor> Instructors { get; set; }
        public DbSet<ContosoUniversity.Models.OfficeAssignment> OfficeAssignments { get; set; }
    }
}
