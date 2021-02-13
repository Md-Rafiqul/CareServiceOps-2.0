using System.Linq;
using System.Threading.Tasks;
using DataHandler;
using Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using MonteServices.MonteAPI.Dtos;
using MonteServices.MonteAPI.Models;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("api/account")]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly TokenService _ts;

        public AccountController(SignInManager<User> signInManager, RoleManager<Role> roleManager, UserManager<User> userManager, TokenService ts)
        { 
            _signInManager = signInManager; 
            _roleManager = roleManager;
            _userManager = userManager;
            _ts = ts;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> login(LoginDto dtoUser)
        {
            User user = await validateUser(dtoUser.Username);
            return user != null ? await signUserIn(user, dtoUser.Password) : BadRequest("User doesn't exists!");
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(User user)
        {
            IdentityResult result = await _userManager.CreateAsync(user, user.Password);
            var roleAssign = await _userManager.AddToRoleAsync(user, "Member");
            if(!roleAssign.Succeeded) return BadRequest(roleAssign.Errors);
            
            return !result.Succeeded ? BadRequest(result.Errors) : 
            new UserDto 
            {
                Username = user.UserName,
                Token = await _ts.CreateToken(user)
            };
        }

        public async Task<User> validateUser(string username)
        {
            User user = await _userManager.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            return user;
        }

        private async Task<ActionResult<UserDto>> signUserIn(User user, string password)
        { 
            var canSignIn = await _signInManager.CheckPasswordSignInAsync(user, password, false);
            return !canSignIn.Succeeded ? Unauthorized() :  
            new UserDto 
            {
                Username = user.UserName,
                Token =  await _ts.CreateToken(user)
            };
        }
    }
}