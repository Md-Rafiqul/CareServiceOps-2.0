using Microsoft.AspNetCore.Identity;
using Models;

namespace MonteServices.MonteAPI.Models
{
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; }
        public Role Role { get; set; }   
    }
}
