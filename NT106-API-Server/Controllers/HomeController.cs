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
        public IActionResult GetNewMovies(string? isTVShows, int limit)
        {
            List<MovieModel.Movie> movies = new List<MovieModel.Movie>();
            limit = limit == 0 ? 14 : limit;
            if (isTVShows != null)
            {
                movies = MovieModel.GetNewMovies(isTVShows == "true", limit);
            } else          
            movies = MovieModel.GetNewMovies();
            return Ok(movies);
        }
        [HttpGet]
        [Route("gettopmoviesbyimdbscore")]
        public IActionResult GetTopMoviesByIMDBScore()
        {
            List<MovieModel.Movie> movies = new List<MovieModel.Movie>();
            movies = MovieModel.GetTopMoviesByIMDbScore();
            return Ok(movies);
        }
    }
}
