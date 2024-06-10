using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
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
                    } else if (result == TokenStatus.Expired)
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
        [Route("uploadbasicdataimdb")]
        [HttpPost]
        [AdminValidateToken]
        public IActionResult UploadBasicDataIMDb([FromBody] MovieModel movieModel, [FromQuery] string method)
        {
            if (ModelState.IsValid)
            {
                if (method == "update")
                {
                    MovieModel.UpdateMovie(movieModel);
                    return Ok();
                }
                if (method == "insert")
                {
                    movieModel.InsertMovie(movieModel.MovieInfo);
                    MovieModel.InsertSeason(movieModel.MovieInfo.MovieId, null, movieModel.Seasons);
                    if (!movieModel.MovieInfo.IsTVShows)
                    {
                        MovieModel.InsertEpisode(new MovieModel.Episodes()
                        {
                            Id = movieModel.MovieInfo.MovieId,
                            MovieId = movieModel.MovieInfo.MovieId,
                            Season = "0"
                        });
                    }
                    foreach (var director in movieModel.Directors)
                    {
                        MovieModel.InsertOrUpdatePerson(director);
                        movieModel.InsertMovieDirector(new MovieModel.MovieDirectors() { MovieId = movieModel.MovieInfo.MovieId, PersonId = director.Id });
                    }
                    foreach (var writer in movieModel.Writers)
                    {
                        MovieModel.InsertOrUpdatePerson(writer);
                        movieModel.InsertMovieWriter(new MovieModel.MovieWriters() { MovieId = movieModel.MovieInfo.MovieId, PersonId = writer.Id });
                    }
                    foreach (var creator in movieModel.Creators)
                    {
                        MovieModel.InsertOrUpdatePerson(creator);
                        movieModel.InsertMovieCreator(new MovieModel.MovieCreator() { MovieId = movieModel.MovieInfo.MovieId, PersonId = creator.Id });
                    }
                    return Ok("{}");
                }
                return NotFound();
            }
            return BadRequest(String.Join("; ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
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
        [Route("getepisodedatafromimdb")]
        [HttpGet]
        [AdminValidateToken]
        public async Task<IActionResult> GetEpisodeDataFromIMDb(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("accept-language", "en-US");
            HttpResponseMessage message = await client.GetAsync(url);
            message.EnsureSuccessStatusCode();
            string htmltext = await message.Content.ReadAsStringAsync();
            HtmlDocument htmldocument = new HtmlDocument();
            htmldocument.LoadHtml(htmltext);

            HtmlNode node = htmldocument.GetElementbyId("__NEXT_DATA__");

            JToken episodeId = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["id"];
            JToken episodeRuntime = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["runtime"]["seconds"];
            JToken episodeVoteCount = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["ratingsSummary"]["voteCount"];
            JToken episodeImageCaption = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["primaryImage"]["caption"]["plainText"];
            JToken episodePlot = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["plot"]["plotText"]["plainText"];
            JToken episodeReleaseDay = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["releaseDate"]["day"];
            JToken episodeReleaseMonth = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["releaseDate"]["month"];
            JToken episodeReleaseYear = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["releaseDate"]["year"];
            JToken episodeAggregateRating = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["ratingsSummary"]["aggregateRating"];
            JToken episodePrimaryImage = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["primaryImage"]["url"];

            JToken genres = JObject.Parse(node.InnerText)["props"]["pageProps"]["aboveTheFoldData"]["genres"]["genres"];
            List<MovieModel.EpisodeGenres> genreList = new List<MovieModel.EpisodeGenres>();
            foreach (JToken genre in genres)
            {
                genreList.Add(new MovieModel.EpisodeGenres()
                {
                    Name = genre["text"].ToString()
                });
            }
            List<MovieModel.EpisodeDirectors> directors = new List<MovieModel.EpisodeDirectors>();
            if (JObject.Parse(node.InnerText)["props"]["pageProps"]["mainColumnData"]["directors"].Count() > 0)
                foreach (var director in JObject.Parse(node.InnerText)["props"]["pageProps"]["mainColumnData"]["directors"][0]["credits"])
                {
                    directors.Add(new MovieModel.EpisodeDirectors()
                    {
                        Person = new MovieModel.Person
                        {
                            Id = director["name"]["id"].ToString(),
                            Name = director["name"]["nameText"]["text"].ToString()
                        }
                    });
                }
            List<MovieModel.EpisodeWriters> writers = new List<MovieModel.EpisodeWriters>();
            if (JObject.Parse(node.InnerText)["props"]["pageProps"]["mainColumnData"]["writers"].Count() > 0)
                foreach (var writer in JObject.Parse(node.InnerText)["props"]["pageProps"]["mainColumnData"]["writers"][0]["credits"])
                {
                    writers.Add(new MovieModel.EpisodeWriters()
                    {
                        Person = new MovieModel.Person
                        {
                            Id = writer["name"]["id"].ToString(),
                            Name = writer["name"]["nameText"]["text"].ToString()
                        }
                    });
                }
            List<MovieModel.EpisodeCreator> creators = new List<MovieModel.EpisodeCreator>();
            if (JObject.Parse(node.InnerText)["props"]["pageProps"]["mainColumnData"]["creators"].Count() > 0)
                foreach (var creator in JObject.Parse(node.InnerText)["props"]["pageProps"]["mainColumnData"]["creators"][0]["credits"])
                {
                    creators.Add(new MovieModel.EpisodeCreator()
                    {
                        Person = new MovieModel.Person
                        {
                            Id = creator["name"]["id"].ToString(),
                            Name = creator["name"]["nameText"]["text"].ToString()
                        }
                    });
                }
            List<MovieModel.Cast> casts = new List<MovieModel.Cast>();
            if (JObject.Parse(node.InnerText)["props"]["pageProps"]["mainColumnData"]["cast"]["edges"].Count() > 0)
                foreach (var cast in JObject.Parse(node.InnerText)["props"]["pageProps"]["mainColumnData"]["cast"]["edges"])
                {
                    foreach (var character in cast["node"]["characters"])
                    {
                        casts.Add(new MovieModel.Cast()
                        {
                            Person = new MovieModel.Person
                            {
                                Id = cast["node"]["name"]["id"].ToString(),
                                Name = cast["node"]["name"]["nameText"]["text"].ToString(),
                                Image = cast["node"]["name"]["primaryImage"].HasValues ? cast["node"]["name"]["primaryImage"]["url"].ToString() : null
                            },
                            CharacterName = character["name"].ToString()
                        });
                    }
                }

            MovieModel.Episodes episode = new MovieModel.Episodes();
            episode.Id = episodeId.ToString();
            episode.Plot = episodePlot.ToString();
            episode.Duration = int.Parse(episodeRuntime.ToString());
            episode.ReleaseDate = new DateTime(int.Parse(episodeReleaseYear.ToString()), int.Parse(episodeReleaseMonth.ToString()), int.Parse(episodeReleaseDay.ToString()));
            episode.AggregateRating = double.Parse(episodeAggregateRating.ToString());
            episode.VoteCount = int.Parse(episodeVoteCount.ToString());
            episode.Image = episodePrimaryImage.ToString();
            episode.ImageCaption = episodeImageCaption.ToString();
            episode.Genres = genreList;
            episode.Directors = directors;
            episode.Writers = writers;
            episode.Creators = creators;
            episode.Casts = casts;

            return Ok(episode);
        }
        [Route("uploadepisodesdata")]
        [HttpPost]
        [AdminValidateToken]
        public IActionResult UploadEpisodesData([FromBody] List<MovieModel.Episodes> episodes)
        {
            if (ModelState.IsValid)
            {
                foreach (var episode in episodes)
                {
                    MovieModel.InsertEpisode(episode);
                }
                return Ok("{}");
            }
            return BadRequest(String.Join("; ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
        }
        [Route("uploadepisodedata")]
        [HttpPost]
        [AdminValidateToken]
        public IActionResult UploadEpisodeData([FromBody] MovieModel.Episodes episode)
        {
            if (ModelState.IsValid)
            {
                MovieModel.UpdateEpisode(episode);
                return Ok("{}");
            }
            return BadRequest(String.Join("; ", ModelState.Values
                                            .SelectMany(v => v.Errors)
                                            .Select(e => e.ErrorMessage)));
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
