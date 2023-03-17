using API.Model;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _moviesService;
        public MoviesController(IMovieService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        [Route("{searchItem}")]
        public IActionResult GetMovies(string searchItem = null)
        {
                return Ok(_moviesService.GetMovies(searchItem));
        }
        
        [HttpPost]
        public IActionResult BookMovie(Booking bookingDetails)
        {
            return Ok(_moviesService.BookMovie(bookingDetails));
        }
    }
}
