using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly DataContext _context;

        public MovieController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Movie>>> Get()
        {
            return Ok(await _context.Movie.ToListAsync());
        }

        [HttpGet("id")]
        public async Task<ActionResult<Movie>> GetbyId(int id)
        {
            var movie =  await _context.Movie.FindAsync(id);
            if (movie == null)
                return BadRequest("Movie not found");
            return Ok(movie);
        }

        [HttpPost]
        public async Task<ActionResult<List<Movie>>> AddMovie(Movie movie)
        {
            _context.Movie.Add(movie);
            await _context.SaveChangesAsync();
            return Ok(await _context.Movie.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Movie>>> UpdateMovie(Movie request)
        {
            var dbMovie = await _context.Movie.FindAsync(request.Id);
            if (dbMovie == null)
                return BadRequest("Movie not found");

            dbMovie.Title = request.Title;
            dbMovie.Director = request.Director;
            dbMovie.Cast = request.Cast;
            dbMovie.ReleaseYear = request.ReleaseYear;
            dbMovie.Duration = request.Duration;
            dbMovie.Categories = request.Categories;
            dbMovie.Description = request.Description;

            await _context.SaveChangesAsync();
            return Ok(await _context.Movie.ToListAsync());
        }

    }
}
