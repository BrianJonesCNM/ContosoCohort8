using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }

        [StringLength(50, ErrorMessage ="Office location must be less than 50 characters")]
        [Display(Name ="Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}