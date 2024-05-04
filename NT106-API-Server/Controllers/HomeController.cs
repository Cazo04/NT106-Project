using Microsoft.AspNetCore.Mvc;
using NT106_WebServer.Models;
using System.Text;

namespace NT106_API_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("test")]
        public IActionResult Test()
        {
            return Ok("Tester");
        }
        [HttpGet]
        [Route("getnewmovies")]
        public IActionResult GetNewMovies()
        {
            List<MovieModel.Movie> movies = new List<MovieModel.Movie>();
            movies = MovieModel.GetNewMovies(7);
            return Ok(movies);
        }
        [HttpGet]
        [Route("gettopmoviesbyimdbscore")]
        public IActionResult GetTopMoviesByIMDBScore()
        {
            List<MovieModel.Movie> movies = new List<MovieModel.Movie>();
            movies = MovieModel.GetTopMoviesByIMDbScore(7);
            return Ok(movies);
        }
    }
}
