using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/movie")]
    public class MovieController : Controller
    {
        // GET api/movie
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/movie/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/movie
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/movie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/movie/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}