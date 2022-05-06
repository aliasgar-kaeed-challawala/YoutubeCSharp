using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication3.Data;
using WebApplication3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YoutubeController : ControllerBase
    {
        protected ApplicationDbContext _db;

        public YoutubeController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: api/<YoutubeController>
        [HttpGet]
        public IEnumerable<Youtube> Get()
        {
            return _db.Youtube.ToList().AsEnumerable();
        }

        // GET api/<YoutubeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<YoutubeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<YoutubeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<YoutubeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
