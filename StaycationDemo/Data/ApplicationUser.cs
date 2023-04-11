using Microsoft.AspNetCore.Identity;

namespace StaycationDemo.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstNAme { get; set; }
        public string LastName { get; set; }
    }
}
