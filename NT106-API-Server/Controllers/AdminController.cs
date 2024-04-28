using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json.Linq;
using NT106_WebServer.Models;
using System.Xml;

namespace NT106_API_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        [Route("login")]
        [HttpPost]
        public IActionResult Login(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                AdminModel admin = new AdminModel();
                if (admin.SignIn(model))
                {
                    TokenStatus result = admin.VerifyRefreshTokenByAdminId(admin.Username);
                    AdminToken token = new AdminToken();
                    if (result == TokenStatus.OK)
                    {
                        token = admin.TempAdminToken;
                        return Ok(token);
                    }
                    else if (result == TokenStatus.NotExist)
                    {
                        token = new AdminToken
                        {
                            AdminId = admin.Username,
                            Token = Guid.NewGuid().ToString(),
                            Expires = DateTime.Now.AddDays(60),
                            IsRevoked = false
                        };
                        admin.InsertAdminToken(token);
                        return Ok(token);
                    }
                    else if (result == TokenStatus.Revoked)
                    {
                        ModelState.AddModelError("UsernameOrEmail", "Your account has been banned.");
                    }
                }
                else
                {
                    ModelState.AddModelError("Password", "Username or password is incorrect.");
                }
            }
            return BadRequest(ModelState);
        }

        [Route("checktoken")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult CheckToken()
        {
            return Ok("Hello, Admin!");
        }

        [Route("moviesmanager")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult MoviesManager([FromQuery] int offset)
        {
            List<MovieModel.Movie> movies = new List<MovieModel.Movie>();
            movies = MovieModel.Get100MoviesLowDetail(offset);
            return Ok(movies);
        }

        [Route("moviescount")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult MoviesCount()
        {
            int count = MovieModel.GetTotalMovies();
            return Ok(count);
        }

        [Route("getmovie")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult GetMovie([FromQuery] string movieId)
        {
            MovieModel movie = MovieModel.GetMovie(movieId);
            return Ok(movie);
        }

        [Route("getmoviedatafromimdb")]
        [HttpGet]
        [AdminValidateToken]
        public async Task<IActionResult> GetMovieDataFromIMDb([FromQuery] string url)
        {
            if (url == null)
            {
                return NotFound();
            }

            MovieModel movieModel = new MovieModel();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("accept-language", "en-US");
            HttpResponseMessage message = await client.GetAsync(url);
            message.EnsureSuccessStatusCode();
            string htmltext = await message.Content.ReadAsStringAsync();
            HtmlDocument htmldocument = new HtmlDocument();
            htmldocument.LoadHtml(htmltext);

            HtmlNodeCollection nodes = htmldocument.DocumentNode.SelectNodes("//script[@type='application/ld+json']");


            #region Get genres
            HtmlNode genresNode = htmldocument.GetElementbyId("__NEXT_DATA__");
            //JToken genres = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["genres"]["genres"];
            //List<string> genreList = new List<string>();
            //foreach (JToken genre in genres)
            //{
            //    genreList.Add(genre["text"].ToString());
            //}

            #endregion
            JToken movieId = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["id"];
            JToken movieName = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["titleText"]["text"];
            JToken movieType = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["titleType"]["isSeries"];
            JToken movieCertificateRating = "Not";
            if (JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["certificate"].HasValues)
                movieCertificateRating = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["certificate"]["rating"];
            JToken movieReleaseDay = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["releaseDate"]["day"];
            JToken movieReleaseMonth = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["releaseDate"]["month"];
            JToken movieReleaseYear = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["releaseDate"]["year"];
            JToken movieRuntime = "0";
            if (JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["runtime"].HasValues)
                movieRuntime = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["runtime"]["seconds"];
            JToken movieAggregateRating = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["ratingsSummary"]["aggregateRating"];
            JToken movieVoteCount = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["ratingsSummary"]["voteCount"];
            //JToken movieCurrentRank = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["meterRanking"]["currentRank"];
            JToken moviePrimaryImage = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["primaryImage"]["url"];
            JToken moviePlot = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["plot"]["plotText"]["plainText"];
            List<MovieModel.Person> directors = new List<MovieModel.Person>();
            if (JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["mainColumnData"]["directors"].Count() > 0)
                foreach (var director in JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["mainColumnData"]["directors"][0]["credits"])
                {
                    directors.Add(new MovieModel.Person
                    {
                        Id = director["name"]["id"].ToString(),
                        Name = director["name"]["nameText"]["text"].ToString()
                    });
                }
            List<MovieModel.Person> writers = new List<MovieModel.Person>();
            if (JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["mainColumnData"]["writers"].Count() > 0)
                foreach (var writer in JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["mainColumnData"]["writers"][0]["credits"])
                {
                    writers.Add(new MovieModel.Person
                    {
                        Id = writer["name"]["id"].ToString(),
                        Name = writer["name"]["nameText"]["text"].ToString()
                    });
                }
            List<MovieModel.Person> creators = new List<MovieModel.Person>();
            if (JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["mainColumnData"]["creators"].Count() > 0)
                foreach (var creator in JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["mainColumnData"]["creators"][0]["credits"])
                {
                    creators.Add(new MovieModel.Person
                    {
                        Id = creator["name"]["id"].ToString(),
                        Name = creator["name"]["nameText"]["text"].ToString()
                    });
                }
            movieModel.MovieInfo = new MovieModel.Movie();
            movieModel.MovieInfo.MovieId = movieId.ToString();
            movieModel.MovieInfo.IsTVShows = bool.Parse(movieType.ToString());
            movieModel.MovieInfo.MovieName = movieName.ToString();
            movieModel.MovieInfo.ReleaseDate = new DateTime(int.Parse(movieReleaseYear.ToString()), int.Parse(movieReleaseMonth.ToString()), int.Parse(movieReleaseDay.ToString()));
            movieModel.MovieInfo.Duration = int.Parse(movieRuntime.ToString());
            movieModel.MovieInfo.ContentRating = movieCertificateRating.ToString();
            movieModel.MovieInfo.IMDbScore = double.Parse(movieAggregateRating.ToString());
            movieModel.MovieInfo.RatingCount = int.Parse(movieVoteCount.ToString());
            movieModel.MovieInfo.PosterURL = moviePrimaryImage.ToString();
            movieModel.MovieInfo.Description = moviePlot.ToString();
            movieModel.Writers = writers;
            movieModel.Directors = directors;
            movieModel.Creators = creators;
            #region Get seasons
            List<MovieModel.Season> seasons = new List<MovieModel.Season>();
            if (movieModel.MovieInfo.IsTVShows)
            {
                int totalSeasons = JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["mainColumnData"]["episodes"]["seasons"].Count();
                for (int i = 1; i <= totalSeasons; i++)
                {
                    seasons.Add(new MovieModel.Season { Name = i.ToString() });
                }
                if (JObject.Parse(genresNode.InnerText)["props"]["pageProps"]["mainColumnData"]["episodes"]["unknownSeasonEpisodes"]["total"].ToString() != "0")
                    seasons.Add(new MovieModel.Season { Name = "Unknown" });
            }
            else seasons.Add(new MovieModel.Season { Name = "0" });
            movieModel.Seasons = seasons;

            #endregion


            #region Get trailer
            if (JObject.Parse(nodes[0].InnerText)["trailer"] != null)
            {
                message.Dispose();
                message = await client.GetAsync(JObject.Parse(nodes[0].InnerText)["trailer"]["url"].ToString());
                message.EnsureSuccessStatusCode();
                string trailer = await message.Content.ReadAsStringAsync();
                htmldocument.LoadHtml(trailer);
                HtmlNode trailerNodes = htmldocument.GetElementbyId("__NEXT_DATA__");
                var jsonObj = JObject.Parse(trailerNodes.InnerText);
                JToken playbackURLs = jsonObj["props"]["pageProps"]["videoPlaybackData"]["video"]["playbackURLs"][1]["url"];

                movieModel.MovieInfo.TrailerURL = playbackURLs.ToString();
            }
            else movieModel.MovieInfo.TrailerURL = null;
            #endregion          

            return Ok(movieModel);
        }
        [Route("episodesmanager")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult EpisodesManager([FromQuery] string movieId, [FromQuery] string seasonId)
        {
            if (movieId == null || seasonId == null)
            {
                return NotFound();
            }
            MovieModel movieModel = new MovieModel();
            movieModel.Episodess = MovieModel.GetEpisodes(movieId, seasonId);
            return Ok(movieModel);
        }
        [Route("episodemanager")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult EpisodeManager([FromQuery] string episodeId)
        {
            if (episodeId == null)
            {
                return NotFound();
            }
            MovieModel.Episodes episode = MovieModel.GetEpisode(episodeId);
            return Ok(episode);
        }
    }

    public class AdminValidateTokenAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var token = context.HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            if (!IsValidToken(token))
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool IsValidToken(string token)
        {
            TokenStatus result = AdminModel.VerifyRefreshToken(token);
            return result == TokenStatus.OK;
        }
    }
}
