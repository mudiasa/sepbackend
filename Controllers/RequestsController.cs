using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sepbackend.Controllers.Resources;
using sepbackend.Core.Models;
using sepbackend.Persistence;

namespace sepbackend.Controllers
{
    [Route("/api/requests")]
    public class RequestsController : ControllerBase
    {
        private readonly SepDbContext context;
        private readonly IMapper mapper;
        public RequestsController(SepDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<RequestResource>> GetRequests()
        {
            var requests = await context.Requests.ToListAsync();
            return mapper.Map<List<Request>, List<RequestResource>>(requests);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequest(int id)
        {
            var request = await context.Requests.FindAsync(id);

            if (request == null)
                return NotFound();

            var eventResource = mapper.Map<Request, RequestResource>(request);

            return Ok(eventResource);

        }

        [HttpPost]
        public async Task<IActionResult> CreateRequest([FromBody] CreateRequestResource requestResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = mapper.Map<CreateRequestResource, Request>(requestResource);
            context.Requests.Add(request);
            await context.SaveChangesAsync();
            var result = mapper.Map<Request, RequestResource>(request);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CreateRequestResource updateRequestResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = await context.Requests.FindAsync(id);
            mapper.Map<CreateRequestResource, Request>(updateRequestResource, request);
       
            await context.SaveChangesAsync();
            
            var result = mapper.Map<Request, RequestResource>(request);
            return Ok(result);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
            var request = await context.Requests.FindAsync(id);

            if (request == null)
                return NotFound();

            context.Remove(request);
            await context.SaveChangesAsync();

            return Ok(id);
        }





    }
}