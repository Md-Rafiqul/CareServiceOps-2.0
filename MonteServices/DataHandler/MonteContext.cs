using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using MonteServices.MonteAPI.Models;

namespace DataHandler{

    //To use Identity, we need to derive db contex from IdentityDbContxt instead of DbContext
    // as we are using int as pkey instead of string, we need to pass in additional arguments for that, otherwise none required
public class MonteContext : IdentityDbContext<User, Role,int,IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    public MonteContext(DbContextOptions options) : base(options){}
    
    
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<User>()
            .HasMany(r => r.UserRoles)
            .WithOne(u => u.User)
            .HasForeignKey(u => u.UserId)
            .IsRequired();
        builder.Entity<User>()
            .HasKey(key => key.Id);    
        builder.Entity<Role>()
            .HasMany(r => r.UserRoles)
            .WithOne(r => r.Role)
            .HasForeignKey(id => id.RoleId)
            .IsRequired();  
        builder.Entity<Role>()
            .HasKey(key => key.Id);       
        
    }
  
}
}
