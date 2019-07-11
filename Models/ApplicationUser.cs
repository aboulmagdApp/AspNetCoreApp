using Microsoft.AspNetCore.Identity;

namespace aspnetcoreNewWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string city { get; set; }
    }
}