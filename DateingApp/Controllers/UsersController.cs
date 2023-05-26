using DateingApp.Data;
using DateingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DateingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]   // GET api/users
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        ////https://localhost:7272/api/users
        //[HttpGet]
        // synchronously
        //public ActionResult<IEnumerable<AppUser>> GetUsers()
        //{
        //    var users = _context.Users.ToList();
        //    return users;
        //}

        [HttpGet]
        // Asynchronously
        public async Task<IEnumerable<AppUser>> GetUsers()
        {

            var users=await _context.Users.ToListAsync(); 
            return  users;
        }

        // https://localhost:7272/api/users/2
        //[HttpGet("{id}")]
        //// synchronously
        //public ActionResult<AppUser> GetUser(int id)
        //{
       
        //    var user = _context.Users.Find(id);
        //    return user;
        //} 

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
