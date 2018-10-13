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
    [Route("/api/clients")]
    public class ClientsController : ControllerBase
    {
        private readonly SepDbContext context;
        private readonly IMapper mapper;
        public ClientsController(SepDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<ClientResource>> GetClients()
        {
            var clients = await context.Clients.ToListAsync();
            return mapper.Map<List<Client>, List<ClientResource>>(clients);
        }

        // [HttpGet("{id}")]
        // public async Task<Client> GetClient(int id)
        // {
        //     return await context.Clients.FindAsync(id);
        // }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var client = await context.Clients.FindAsync(id);

            if (client == null)
                return NotFound();

            var clientResource = mapper.Map<Client, ClientResource>(client);

            return Ok(clientResource);

        }

        [HttpPost]
        public async Task<IActionResult> CreateClient([FromBody] CreateClientResource clientResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);   
                
            var client = mapper.Map<CreateClientResource, Client>(clientResource);
            context.Clients.Add(client);
            await context.SaveChangesAsync();
            var result = mapper.Map<Client, ClientResource>(client);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, [FromBody] ClientResource clientResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var client = await context.Clients.FindAsync(id);

            if (client == null)
                return NotFound();

            mapper.Map<ClientResource, Client>(clientResource, client);
            

            await context.SaveChangesAsync();
            var result = mapper.Map<Client, ClientResource>(client);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var client = await context.Clients.FindAsync(id);

            if (client == null)
                return NotFound();

            context.Remove(client);
            await context.SaveChangesAsync();

            return Ok(id);
        }
    }
}