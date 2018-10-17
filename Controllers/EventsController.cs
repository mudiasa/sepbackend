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
    [Route("/api/events")]
    public class EventsController : ControllerBase
    {
        private readonly SepDbContext context;
        private readonly IMapper mapper;
        public EventsController(SepDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<EventResource>> GetEvents()
        {
            var events = await context.Events.ToListAsync();
            return mapper.Map<List<Event>, List<EventResource>>(events);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent(int id)
        {
            var myEvent = await context.Events.FindAsync(id);

            if (myEvent == null)
                return NotFound();

            var eventResource = mapper.Map<Event, EventResource>(myEvent);

            return Ok(eventResource);

        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventResource eventResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var myEvent = mapper.Map<CreateEventResource, Event>(eventResource);
            context.Events.Add(myEvent);
            await context.SaveChangesAsync();
            var result = mapper.Map<Event, EventResource>(myEvent);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CreateEventResource updateEventResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var myEvent = await context.Events.FindAsync(id);
            mapper.Map<CreateEventResource, Event>(updateEventResource, myEvent);

            await context.SaveChangesAsync();

            var result = mapper.Map<Event, CreateEventResource>(myEvent);
            return Ok(result);

        }

        // [HttpPut("{id}")]
        // public async Task<IActionResult> UpdateEvent(int id, [FromBody] CreateEventResource updateEventResource)
        // {
        //     if (!ModelState.IsValid)
        //         return BadRequest(ModelState);

        //     var myEvent = await context.Events.FindAsync(id);

        
        //     mapper.Map<CreateEventResource, Event>(updateEventResource);
        
        //     await context.SaveChangesAsync();
        //     var result = mapper.Map<Event, EventResource>(myEvent);
        //     return Ok(result);

        // }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var myEvent = await context.Events.FindAsync(id);

            if (myEvent == null)
                return NotFound();

            context.Remove(myEvent);
            await context.SaveChangesAsync();

            return Ok(id);
        }



    }
}