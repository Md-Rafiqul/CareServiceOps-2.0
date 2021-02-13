using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using MonteServices.MonteAPI.Models;

namespace Models
{
    public class User : IdentityUser<int>//define int to use int as primary key instead of string, which is default
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Password { get; set; }
        
        
        public string CompanyEmailAddress { get; set; }   
        public virtual ICollection<UserRole> UserRoles { get; set; }
        
        
    }
}