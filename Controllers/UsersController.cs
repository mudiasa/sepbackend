using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sepbackend.Controllers.Resources;
using sepbackend.Core.Models;
using sepbackend.Persistence;

namespace sepbackend.Controllers
{
    [Route("/api/users")]
    public class UsersController : ControllerBase
    {
        private readonly SepDbContext context;
        private readonly IMapper mapper;
        public UsersController(SepDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<UserResource>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return mapper.Map<List<User>, List<UserResource>>(users);
        }
        

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            var userResource = mapper.Map<User, UserResource>(user);

            return Ok(userResource);

        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserResource userResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = mapper.Map<CreateUserResource, User>(userResource);
            context.Users.Add(user);
            await context.SaveChangesAsync();
            var result = mapper.Map<User, UserResource>(user);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            context.Remove(user);
            await context.SaveChangesAsync();

            return Ok(id);
        }



    }
}