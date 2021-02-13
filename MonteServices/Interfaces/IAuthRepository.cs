using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Interfaces
{
    public interface IAuthRepository
    {
       public Task<ActionResult<string>> Login(string Username, string Password);
       public Task<ActionResult> Register(User user);
       
       public Task<User> validateUser(string username);
       public Task<ActionResult<string>> GenerateJwtToken();
    }
}