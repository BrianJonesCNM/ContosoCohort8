using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        
        [StringLength(50, MinimumLength =3, ErrorMessage ="Course Title must be greater than 3 and less than 50 characters.")]
        public string Title { get; set; }

        [Range(0,5, ErrorMessage ="Credits can be >= 0 and <=5.")]
        public int  Credits { get; set; }

        public int DepartmentID { get; set; }

        //naivagtional Properties
        public ICollection<Enrollment> Enrollments { get; set; }
        public Department Department { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}