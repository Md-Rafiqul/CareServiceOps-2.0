using System.Collections.Generic;
using System.Linq;
using DataHandler;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MonteServices.MonteAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [AllowAnonymous]
    public class UsersController : ControllerBase
    {
        private readonly MonteContext _context;
        public UsersController(MonteContext context)
        {
            _context = context;
        }
        //[Authorize(Roles="Admin")]
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _context.Users.ToList().Count()>0 ? _context.Users.ToList(): Content("No User Found!");
        }

        //[Authorize(Roles="Member")]
        [HttpGet("{id}")]
        public ActionResult<User> getUserById(int id)
        {
            User user = _context.Users.Where(uid => uid.Id == id).FirstOrDefault();
 
            return user != null ? user: new EmptyResult() ;
        }

        // [HttpGet("{username}")]
        // public ActionResult<User> getUserByUserName(string username)
        // {
             
        //     User user = _context.Users.Where(u => u.UserName == username).FirstOrDefault();
        //     return user!= null ? user : new EmptyResult();
        // }
        
       
    }
}