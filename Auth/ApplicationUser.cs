using Microsoft.AspNetCore.Identity;

namespace TESTKUSUM.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName;
    }
}
