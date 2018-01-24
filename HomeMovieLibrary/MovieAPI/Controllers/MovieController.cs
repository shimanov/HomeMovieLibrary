using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Context;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/movie")]
    [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)]
    public class MovieController : Controller
    {
        MovieContext movieContext;

        public MovieController(MovieContext context)
        {
            movieContext = context;
        }

        // GET api/movie
        [HttpGet]
        public IEnumerable<MovieModel> Get()
        {
            return movieContext.Movies.ToList();
        }

        // GET api/movie/5
        [HttpGet("{id}", Name ="GetMovie")]
        public IActionResult Get(int id)
        {
            var result = movieContext.Movies.First(x => x.Id == id);
            if (result == null)
            {

                //Реализовать поиск в api.themoviedb.org и сохранение в БД
                return NotFound();
            }
            return new OkObjectResult(result);
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