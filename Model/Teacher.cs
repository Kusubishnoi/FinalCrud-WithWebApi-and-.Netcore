using System.ComponentModel.DataAnnotations;

namespace TESTKUSUM.Model
{
    public class Teacher
    {
        [Key]
        public string TeacherId { get; set; }
        [Required(ErrorMessage = "TeacherName is required")]           
        public string TeacherName { get; set; }
        [Required(ErrorMessage = "TeacherSubject is required")]
        
        public string TeacherEmail { get; set; }
        //public string TeacherPassword { get; set; }
    }
}

