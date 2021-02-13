using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MonteServices.MonteAPI.Models
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRoles{ get; set; }
        
        
    }
}