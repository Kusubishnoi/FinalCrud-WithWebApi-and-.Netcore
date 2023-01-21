using System.ComponentModel.DataAnnotations;
namespace TESTKUSUM.Auth

{ 
    public class Register
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? FullName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
