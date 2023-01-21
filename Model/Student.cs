using System.ComponentModel.DataAnnotations;

namespace TESTKUSUM.Model
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
    }
}
