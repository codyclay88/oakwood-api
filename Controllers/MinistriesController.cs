using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OakwoodApp.Entities;

namespace OakwoodApp.Controllers
{
    [Route("api/[controller]")]
    public class MinistriesController : Controller
    {
        private readonly OakwoodDbContext _context;

        public MinistriesController(OakwoodDbContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Ministries.Include(m => m.OakwoodEvents));
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "MinistryDetails")]
        public IActionResult Get(int id)
        {
            var ministry = _context.Ministries.Include(m => m.OakwoodEvents).FirstOrDefault(m => m.Id == id);
            if(ministry == null)
            {
                return NotFound();
            }
            return Ok(ministry);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Ministry ministry)
        {
            var newMinistry = _context.Ministries.Add(ministry);
            _context.SaveChanges();

            return CreatedAtRoute("MinistryDetails", new { Id = newMinistry.Entity.Id }, newMinistry.Entity);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Ministry ministry)
        {
            _context.Ministries.Update(ministry);
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ministry = _context.Ministries.FirstOrDefault(m => m.Id == id);
            _context.Ministries.Remove(ministry);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
