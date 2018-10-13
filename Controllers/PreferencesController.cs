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
    [Route("/api/preferences")]
    public class PreferencesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly SepDbContext context;
        public PreferencesController(SepDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PreferenceResource>> GetPreferences()
        {
            var preferences = await context.Preferences.ToListAsync();
            return mapper.Map<List<Preference>, List<PreferenceResource>>(preferences);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetPreference(int id)
        {
            var reference = await context.Preferences.FindAsync(id);

            if (reference == null)
                return NotFound();

            var referenceResource = mapper.Map<Preference, PreferenceResource>(reference);

            return Ok(referenceResource);

        }

        [HttpPost]
        public async Task<IActionResult> CreatePreference([FromBody] CreatePreferenceResource preferenceResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var preference = mapper.Map<CreatePreferenceResource, Preference>(preferenceResource);
            context.Preferences.Add(preference);
            await context.SaveChangesAsync();
            var result = mapper.Map<Preference, PreferenceResource>(preference);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreference(int id)
        {
            var preference = await context.Preferences.FindAsync(id);

            if (preference == null)
                return NotFound();

            context.Remove(preference);
            await context.SaveChangesAsync();

            return Ok(id);
        }



    }
}