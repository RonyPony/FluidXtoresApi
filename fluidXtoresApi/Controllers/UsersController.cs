#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using fluidXtoresApi.Models;
using fluidXtoresApi.dto;
using Microsoft.AspNetCore.Authorization;

namespace fluidXtoresApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly IJWTManagerRepository _jWTManager;
        private readonly fluidContext _context;

        public UsersController(
            fluidContext context
            //,IJWTManagerRepository jWTManager
            )
        {
            _context = context;
            //this._jWTManager = jWTManager;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            user.LastLoginDate = DateTime.UtcNow;
            user.UserRegisterDate = DateTime.UtcNow;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }

        // POST: api/LoginUser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginUser(loginUserDto user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }
                var userInfo = _context.Users.Where(b => b.UserEmail == user.UserEmail).FirstOrDefault();
                
                if (userInfo == null)
                {
                    return NotFound(user.UserEmail + " does not exist");
                }
                userDto usr = new userDto() { UserName = userInfo.UserName, UserEmail = userInfo.UserEmail, UserPassword = userInfo.UserPassword, LastLoginDate = userInfo.LastLoginDate, UserRegisterDate = userInfo.UserRegisterDate };
                if (userInfo.UserPassword == user.UserPassword)
                {
                    userInfo.LastLoginDate = DateTime.UtcNow;

                    _context.Users.Update(userInfo);
                    await _context.SaveChangesAsync();
                    //_context.SaveChanges();
                    return Ok(userInfo);
                }
                else
                {
                    return Unauthorized("Login failed, please check your credentials");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("authenticate")]
        //public IActionResult Authenticate(User usersdata)
        //{
        //    var token = _jWTManager.Authenticate(usersdata);

        //    if (token == null)
        //    {
        //        return Unauthorized();
        //    }

        //    return Ok(token);
        //}

        // GET: api/Users/email
        [HttpGet("find")]
        public async Task<IActionResult> getUserByEmail([FromQuery(Name = "email")] string email)
        {
            var user =  _context.Users.Where(x => x.UserEmail.Equals(email));

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
