using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static NT106_WebServer.Models.MovieModel;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace NT106_WebServer.Models
{
    public class MovieModel
    {
        [Required]
        public Movie MovieInfo { get; set; }
        public List<Episodes>? Episodess { get; set; }
        public List<Season> Seasons { get; set; }
        public List<Person> Directors { get; set; }
        public List<Person> Writers { get; set; }
        public List<Person> Creators { get; set; }
        public List<Cast>? Casts { get; set; }
        public List<string>? Genres { get; set; }

        public static List<Movie> GetNewMovies(bool? isTVShows = null, int count = 7)
        {
            var movies = new List<Movie>();
            string tvshow_query = "";
            if (isTVShows != null)
            {
                tvshow_query = " WHERE IsTVShows = " + (isTVShows.Value ? "1" : "0");
            }

            using (var connection = MySQLServer.GetWorkingConnection())
            {
                string query = @"SELECT MovieId, MovieName, ContentRating, IMDbScore, PosterURL, IsTVShows
                         FROM Movies
                             " + tvshow_query + @"
                         ORDER BY ReleaseDate DESC
                         LIMIT @Count";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count", count);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var movie = new Movie
                            {
                                MovieId = reader.GetString("MovieId"),
                                MovieName = reader.GetString("MovieName"),
                                ContentRating = reader.GetString("ContentRating"),
                                IMDbScore = reader.GetDouble("IMDbScore"),
                                PosterURL = reader.GetString("PosterURL"),
                                IsTVShows = reader.GetBoolean("IsTVShows")
                            };
                            movies.Add(movie);
                        }
                    }
                }
            }

            return movies;
        }
        public static List<Movie> GetTopMoviesByIMDbScore(bool? isTVShows = null, int count = 7)
        {
            var movies = new List<Movie>();
            string tvshow_query = "";
            if (isTVShows != null)
            {
                tvshow_query = " AND IsTVShows = " + (isTVShows.Value ? "1" : "0");
            }

            using (var connection = MySQLServer.GetWorkingConnection())
            {
                string query = @"SELECT MovieId, MovieName, ContentRating, IMDbScore, PosterURL, IsTVShows
                         FROM Movies
                         WHERE ReleaseDate >= @StartDate " + tvshow_query + @" 
                         ORDER BY IMDbScore DESC
                         LIMIT @Count";

                using (var command = new MySqlCommand(query, connection))
                {
                    var startDate = DateTime.Now.AddMonths(-1);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@Count", count);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var movie = new Movie
                            {
                                MovieId = reader.GetString("MovieId"),
                                MovieName = reader.GetString("MovieName"),
                                ContentRating = reader.GetString("ContentRating"),
                                IMDbScore = reader.GetDouble("IMDbScore"),
                                PosterURL = reader.GetString("PosterURL"),
                                IsTVShows = reader.GetBoolean("IsTVShows")
                            };
                            movies.Add(movie);
                        }
                    }
                }
            }

            return movies;
        }
        public static List<Movie> GetTopMoviesByIMDbScoreButNotInNewMovies(bool? isTVShows = null, int count = 7)
        {
            var movies = new List<Movie>();
            string tvshow_query = "";
            if (isTVShows != null)
            {
                tvshow_query = " AND IsTVShows = " + (isTVShows.Value ? "1" : "0");
            }

            using (var connection = MySQLServer.GetWorkingConnection())
            {
                string query = @"WITH LatestMovies AS (
                        SELECT MovieId
                        FROM Movies
                        ORDER BY ReleaseDate DESC
                        LIMIT 7
                    )
                    SELECT MovieId, MovieName, ContentRating, IMDbScore, PosterURL, IsTVShows
                    FROM Movies
                    WHERE MovieId NOT IN (SELECT MovieId FROM LatestMovies) " + tvshow_query + @"
                    ORDER BY IMDbScore DESC
                    LIMIT @Count";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count", count);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var movie = new Movie
                            {
                                MovieId = reader.GetString("MovieId"),
                                MovieName = reader.GetString("MovieName"),
                                ContentRating = reader.GetString("ContentRating"),
                                IMDbScore = reader.GetDouble("IMDbScore"),
                                PosterURL = reader.GetString("PosterURL"),
                                IsTVShows = reader.GetBoolean("IsTVShows")
                            };
                            movies.Add(movie);
                        }
                    }
                }
            }

            return movies;
        }
        public void InsertMovie(Movie movie)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = @"INSERT INTO Movies (MovieId, MovieName, ReleaseDate, Duration, ContentRating, IMDbScore, RatingCount, PosterURL, BackgroundURL, TrailerURL, Description, IsTVShows) 
                                   VALUES (@MovieId, @MovieName, @ReleaseDate, @Duration, @ContentRating, @IMDbScore, @RatingCount, @PosterURL, @BackgroundURL, @TrailerURL, @Description, @IsTVShows)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movie.MovieId);
                    command.Parameters.AddWithValue("@MovieName", movie.MovieName);
                    command.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                    command.Parameters.AddWithValue("@Duration", movie.Duration);
                    command.Parameters.AddWithValue("@ContentRating", movie.ContentRating);
                    command.Parameters.AddWithValue("@IMDbScore", movie.IMDbScore);
                    command.Parameters.AddWithValue("@RatingCount", movie.RatingCount);
                    command.Parameters.AddWithValue("@PosterURL", movie.PosterURL);
                    command.Parameters.AddWithValue("@BackgroundURL", movie.BackgroundURL);
                    command.Parameters.AddWithValue("@TrailerURL", movie.TrailerURL);
                    command.Parameters.AddWithValue("@Description", movie.Description);
                    command.Parameters.AddWithValue("@IsTVShows", movie.IsTVShows);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static bool CheckMovieExists(string movieId)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = "SELECT EXISTS(SELECT 1 FROM Movies WHERE MovieId = @MovieId) AS MovieExists;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);

                    bool exists = Convert.ToBoolean(command.ExecuteScalar());
                    return exists;
                }
            }
        }
        public static int GetTotalMovies()
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = "SELECT COUNT(*) FROM Movies";

                using (var command = new MySqlCommand(query, connection))
                {
                    int totalMovies = Convert.ToInt32(command.ExecuteScalar());
                    return totalMovies;
                }
            }
        }
        public static void InsertSeason(string movieId, Season? season, List<Season>? seasons = null)
        {
            if (seasons == null)
                if (season == null)
                    return;
                else seasons = new List<Season> { season };

            foreach (var item in seasons)
            {
                using (var connection = MySQLServer.GetWorkingConnection())
                {
                    const string query = @"INSERT INTO Seasons (MovieId, Name) VALUES (@MovieId, @Name)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MovieId", movieId);
                        command.Parameters.AddWithValue("@Name", item.Name);

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            if (ex.Number == 1062)
                            {
                                //Console.WriteLine("Duplicate entry detected and ignored.");
                            }
                            else
                            {
                                throw new Exception("Error while inserting season", ex);
                            }
                        }
                    }
                }
            }
        }
        public static List<Season> GetSeasons(string movieId)
        {
            List<Season> Seasons = new List<Season>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = @"SELECT Name FROM Seasons WHERE MovieId = @MovieId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Seasons.Add(new Season
                            {
                                Name = reader.GetString("Name")
                            });
                        }
                    }
                }
            }
            return Seasons;
        }
        public static void InsertEpisode(Episodes episode)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = @"INSERT INTO Episodes (Id, MovieId, Season, Episode, ReleaseDate, Duration, Image, ImageCaption, Title, Plot, AggregateRating, VoteCount) 
                                   VALUES (@Id, @MovieId, @Season, @Episode, @ReleaseDate, @Duration, @Image, @ImageCaption, @Title, @Plot, @AggregateRating, @VoteCount)
                                    ON DUPLICATE KEY UPDATE 
                       ReleaseDate=@ReleaseDate, Image=@Image, Title=@Title, AggregateRating=@AggregateRating;";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", episode.Id);
                    command.Parameters.AddWithValue("@MovieId", episode.MovieId);
                    command.Parameters.AddWithValue("@Season", episode.Season);
                    command.Parameters.AddWithValue("@Episode", episode.Episode);
                    command.Parameters.AddWithValue("@ReleaseDate", episode.ReleaseDate);
                    command.Parameters.AddWithValue("@Duration", episode.Duration);
                    command.Parameters.AddWithValue("@Image", episode.Image);
                    command.Parameters.AddWithValue("@ImageCaption", episode.ImageCaption);
                    command.Parameters.AddWithValue("@Title", episode.Title);
                    command.Parameters.AddWithValue("@Plot", episode.Plot);
                    command.Parameters.AddWithValue("@AggregateRating", episode.AggregateRating);
                    command.Parameters.AddWithValue("@VoteCount", episode.VoteCount);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateEpisode(Episodes episode)
        {
            if (!CheckMovieExists(episode.Id))
            {
                using (var connection = MySQLServer.GetWorkingConnection())
                {
                    const string query = @"UPDATE Episodes 
                               SET Episode = @Episode, 
                                   ReleaseDate = @ReleaseDate, 
                                   Duration = @Duration, 
                                   Image = @Image, 
                                   ImageCaption = @ImageCaption, 
                                   Title = @Title, 
                                   Plot = @Plot, 
                                   AggregateRating = @AggregateRating, 
                                   VoteCount = @VoteCount 
                               WHERE Id = @Id";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", episode.Id);
                        // command.Parameters.AddWithValue("@MovieId", episode.MovieId); // Not used in UPDATE
                        // command.Parameters.AddWithValue("@Season", episode.Season); // Not used in UPDATE
                        command.Parameters.AddWithValue("@Episode", episode.Episode);
                        command.Parameters.AddWithValue("@ReleaseDate", episode.ReleaseDate);
                        command.Parameters.AddWithValue("@Duration", episode.Duration);
                        command.Parameters.AddWithValue("@Image", episode.Image);
                        command.Parameters.AddWithValue("@ImageCaption", episode.ImageCaption);
                        command.Parameters.AddWithValue("@Title", episode.Title);
                        command.Parameters.AddWithValue("@Plot", episode.Plot);
                        command.Parameters.AddWithValue("@AggregateRating", episode.AggregateRating);
                        command.Parameters.AddWithValue("@VoteCount", episode.VoteCount);
                        command.ExecuteNonQuery();
                    }
                }

                foreach (var person in episode.Directors)
                {
                    InsertOrUpdatePerson(person.Person, false, true);
                }
                foreach (var person in episode.Writers)
                {
                    InsertOrUpdatePerson(person.Person, false, true);
                }
                foreach (var person in episode.Creators)
                {
                    InsertOrUpdatePerson(person.Person, false, true);
                }
                UpdateEpisodeCreators(episode.Id, episode.Creators.Select(c => c.Person.Id).ToList());
                UpdateEpisodeDirectors(episode.Id, episode.Directors.Select(d => d.Person.Id).ToList());
                UpdateEpisodeWriters(episode.Id, episode.Writers.Select(w => w.Person.Id).ToList());
            }
            foreach (var person in episode.Casts)
            {
                InsertOrUpdatePerson(person.Person, false, true);
            }
            UpdateEpisodeGenre(episode.Id, episode.Genres.Select(g => g.Name).ToList());
            //UpdateEpisodeKeyword(episode.Id, episode.Keywords.Select(k => k.Name).ToList());
            UpdateCast(episode.Id, episode.Casts);
        }
        public static List<Episodes> GetEpisodes(string movieId, string seasonId)
        {
            List<Episodes> episodes = new List<Episodes>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = @"SELECT Id, MovieId, Season, Episode, ReleaseDate, Duration, Image, ImageCaption, Title, Plot, AggregateRating, VoteCount 
                          FROM Episodes
                          WHERE MovieId = @MovieId AND Season = @Season";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);
                    command.Parameters.AddWithValue("@Season", seasonId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            episodes.Add(new Episodes
                            {
                                Id = reader.GetString("Id"),
                                MovieId = reader.GetString("MovieId"),
                                Season = reader.GetString("Season"),
                                Episode = reader.IsDBNull("Episode") ? null : reader.GetString("Episode"),
                                ReleaseDate = reader.IsDBNull("ReleaseDate") ? null : reader.GetDateTime("ReleaseDate"),
                                Duration = reader.IsDBNull("Duration") ? null : reader.GetInt32("Duration"),
                                Image = reader.IsDBNull("Image") ? null : reader.GetString("Image"),
                                ImageCaption = reader.IsDBNull("ImageCaption") ? null : reader.GetString("ImageCaption"),
                                Title = reader.IsDBNull("Title") ? null : reader.GetString("Title"),
                                Plot = reader.IsDBNull("Plot") ? null : reader.GetString("Plot"),
                                AggregateRating = reader.IsDBNull("AggregateRating") ? null : reader.GetDouble("AggregateRating"),
                                VoteCount = reader.IsDBNull("VoteCount") ? null : reader.GetInt32("VoteCount")
                            });
                        }
                    }
                }
            }

            return episodes;
        }
        public static Episodes GetEpisode(string episodeId)
        {
            Episodes episode = new Episodes();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = @"SELECT Id, MovieId, Season, Episode, ReleaseDate, Duration, Image, ImageCaption, Title, Plot, AggregateRating, VoteCount 
                          FROM Episodes
                          WHERE Id = @Id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", episodeId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            episode.Id = reader.GetString("Id");
                            episode.MovieId = reader.GetString("MovieId");
                            episode.Season = reader.GetString("Season");
                            episode.Episode = reader.IsDBNull("Episode") ? null : reader.GetString("Episode");
                            episode.ReleaseDate = reader.IsDBNull("ReleaseDate") ? null : reader.GetDateTime("ReleaseDate");
                            episode.Duration = reader.IsDBNull("Duration") ? 0 : reader.GetInt32("Duration");
                            episode.Image = reader.IsDBNull("Image") ? null : reader.GetString("Image");
                            episode.ImageCaption = reader.IsDBNull("ImageCaption") ? null : reader.GetString("ImageCaption");
                            episode.Title = reader.IsDBNull("Title") ? null : reader.GetString("Title");
                            episode.Plot = reader.IsDBNull("Plot") ? null : reader.GetString("Plot");
                            episode.AggregateRating = reader.IsDBNull("AggregateRating") ? null : reader.GetDouble("AggregateRating");
                            episode.VoteCount = reader.IsDBNull("VoteCount") ? null : reader.GetInt32("VoteCount");
                        }
                    }
                }
            }
            episode.Writers = GetEpisodeWriters(episodeId);
            episode.Directors = GetEpisodeDirectors(episodeId);
            episode.Creators = GetEpisodeCreators(episodeId);
            episode.Genres = GetEpisodeGenres(episodeId);
            episode.Keywords = GetEpisodeKeywords(episodeId);
            episode.Casts = GetCast(episodeId);
            return episode;
        }
        public List<Movie> Get100Movies(int pageNumber = 0)
        {
            if (pageNumber < 0) pageNumber = 0;
            List<Movie> movies = new List<Movie>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                int offset = pageNumber * 100;

                var query = @"SELECT MovieId, MovieName, ReleaseDate, Duration, ContentRating, IMDbScore, RatingCount, 
                                 PosterURL, BackgroundURL, TrailerURL, Description, IsTVShows 
                          FROM Movies
                          ORDER BY ReleaseDate DESC
                          LIMIT 100 OFFSET @Offset";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Offset", offset);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie
                            {
                                MovieId = reader.GetString("MovieId"),
                                MovieName = reader.GetString("MovieName"),
                                ReleaseDate = reader.GetDateTime("ReleaseDate"),
                                Duration = reader.GetInt32("Duration"),
                                ContentRating = reader.GetString("ContentRating"),
                                IMDbScore = reader.GetDouble("IMDbScore"),
                                RatingCount = reader.GetInt32("RatingCount"),
                                PosterURL = reader.GetString("PosterURL"),
                                BackgroundURL = reader.GetString("BackgroundURL"),
                                TrailerURL = reader.GetString("TrailerURL"),
                                Description = reader.GetString("Description"),
                                IsTVShows = reader.GetBoolean("IsTVShows")
                            });
                        }
                    }
                }
            }

            return movies;
        }
        public static List<Movie> Get100MoviesLowDetail(int pageNumber = 0)
        {
            if (pageNumber < 0) pageNumber = 0;
            List<Movie> movies = new List<Movie>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                int offset = pageNumber * 100;

                var query = @"SELECT MovieId, MovieName, ReleaseDate, Duration, ContentRating, IMDbScore, IsTVShows 
                          FROM Movies
                          ORDER BY ReleaseDate DESC
                          LIMIT 100 OFFSET @Offset";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Offset", offset);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie
                            {
                                MovieId = reader.GetString("MovieId"),
                                MovieName = reader.GetString("MovieName"),
                                ReleaseDate = reader.GetDateTime("ReleaseDate"),
                                Duration = reader.GetInt32("Duration"),
                                ContentRating = reader.GetString("ContentRating"),
                                IMDbScore = reader.GetDouble("IMDbScore"),
                                IsTVShows = reader.GetBoolean("IsTVShows")
                            });
                        }
                    }
                }
            }

            return movies;
        }
        public static MovieModel GetMovie(string id)
        {
            MovieModel movieModel = new MovieModel();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = @"SELECT MovieId, MovieName, ReleaseDate, Duration, ContentRating, IMDbScore, RatingCount, 
                                 PosterURL, BackgroundURL, TrailerURL, Description, IsTVShows 
                          FROM Movies
                          WHERE MovieId = @MovieId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            movieModel.MovieInfo = new Movie
                            {
                                MovieId = reader.GetString("MovieId"),
                                MovieName = reader.GetString("MovieName"),
                                ReleaseDate = reader.GetDateTime("ReleaseDate"),
                                Duration = reader.GetInt32("Duration"),
                                ContentRating = reader.GetString("ContentRating"),
                                IMDbScore = reader.GetDouble("IMDbScore"),
                                RatingCount = reader.GetInt32("RatingCount"),
                                PosterURL = reader.GetString("PosterURL"),
                                //BackgroundURL = reader.GetString("BackgroundURL"),
                                TrailerURL = reader.GetString("TrailerURL"),
                                Description = reader.GetString("Description"),
                                IsTVShows = reader.GetBoolean("IsTVShows")
                            };
                        }
                    }
                }
            }
            if (movieModel.MovieInfo == null) return new MovieModel();
            movieModel.Directors = GetMovieDirectors(id);
            movieModel.Writers = GetMovieWriters(id);
            movieModel.Creators = GetMovieCreators(id);
            movieModel.Seasons = GetSeasons(id);
            return movieModel;
        }
        public static void UpdateMovie(MovieModel movieModel)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = @"
            UPDATE Movies
            SET 
                MovieName = @MovieName,
                ReleaseDate = @ReleaseDate,
                Duration = @Duration,
                ContentRating = @ContentRating,
                IMDbScore = @IMDbScore,
                RatingCount = @RatingCount,
                PosterURL = @PosterURL,
                BackgroundURL = @BackgroundURL,
                TrailerURL = @TrailerURL,
                Description = @Description,
                IsTVShows = @IsTVShows
            WHERE MovieId = @MovieId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieModel.MovieInfo.MovieId);
                    command.Parameters.AddWithValue("@MovieName", movieModel.MovieInfo.MovieName);
                    command.Parameters.AddWithValue("@ReleaseDate", movieModel.MovieInfo.ReleaseDate);
                    command.Parameters.AddWithValue("@Duration", movieModel.MovieInfo.Duration);
                    command.Parameters.AddWithValue("@ContentRating", movieModel.MovieInfo.ContentRating);
                    command.Parameters.AddWithValue("@IMDbScore", movieModel.MovieInfo.IMDbScore);
                    command.Parameters.AddWithValue("@RatingCount", movieModel.MovieInfo.RatingCount);
                    command.Parameters.AddWithValue("@PosterURL", movieModel.MovieInfo.PosterURL);
                    command.Parameters.AddWithValue("@BackgroundURL", movieModel.MovieInfo.BackgroundURL);
                    command.Parameters.AddWithValue("@TrailerURL", movieModel.MovieInfo.TrailerURL);
                    command.Parameters.AddWithValue("@Description", movieModel.MovieInfo.Description);
                    command.Parameters.AddWithValue("@IsTVShows", movieModel.MovieInfo.IsTVShows);

                    int result = command.ExecuteNonQuery();
                }
            }
            foreach (var person in movieModel.Directors)
            {
                InsertOrUpdatePerson(person);
            }
            foreach (var person in movieModel.Writers)
            {
                InsertOrUpdatePerson(person);
            }
            foreach (var person in movieModel.Creators)
            {
                InsertOrUpdatePerson(person);
            }

            UpdateMovieCreators(movieModel.MovieInfo.MovieId, movieModel.Creators.Select(c => c.Id).ToList());
            UpdateMovieDirectors(movieModel.MovieInfo.MovieId, movieModel.Directors.Select(d => d.Id).ToList());
            UpdateMovieWriters(movieModel.MovieInfo.MovieId, movieModel.Writers.Select(w => w.Id).ToList());
            InsertSeason(movieModel.MovieInfo.MovieId, null, movieModel.Seasons);
        }

        public static void InsertOrUpdatePerson(Person person, bool IsUpdateName = false, bool IsUpdateImage = false)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var checkQuery = "SELECT COUNT(*) FROM Person WHERE Id = @Id";
                using (var checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@Id", person.Id);
                    var exists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;

                    if (!exists)
                    {
                        var insertQuery = "INSERT INTO Person (Id, Name, Image) VALUES (@Id, @Name, @Image)";
                        using (var insertCmd = new MySqlCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@Id", person.Id);
                            insertCmd.Parameters.AddWithValue("@Name", person.Name);
                            insertCmd.Parameters.AddWithValue("@Image", person.Image);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                    else if (IsUpdateImage || IsUpdateName)
                    {
                        var updateQuery = "UPDATE Person SET ";
                        if (IsUpdateName)
                        {
                            updateQuery += "Name = @Name";
                        }
                        if (IsUpdateImage)
                        {
                            if (IsUpdateName) updateQuery += ", ";
                            updateQuery += "Image = @Image";
                        }
                        updateQuery += " WHERE Id = @Id";

                        using (var updateCmd = new MySqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@Id", person.Id);
                            if (IsUpdateName)
                            {
                                updateCmd.Parameters.AddWithValue("@Name", person.Name);
                            }
                            if (IsUpdateImage)
                            {
                                updateCmd.Parameters.AddWithValue("@Image", person.Image);
                            }
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        public void InsertMovieDirector(MovieDirectors director)
        {
            InsertRelationship("MovieDirectors", director.MovieId, new List<string> { director.PersonId });
        }
        public void InsertMovieWriter(MovieWriters writer)
        {
            InsertRelationship("MovieWriters", writer.MovieId, new List<string> { writer.PersonId });
        }
        public void InsertMovieCreator(MovieCreator creator)
        {
            InsertRelationship("MovieCreator", creator.MovieId, new List<string> { creator.PersonId });
        }
        private static int InsertRelationship(string tableName, string movieId, List<string> idsToAdd)
        {
            foreach (var id in idsToAdd)
            {
                using (var connection = MySQLServer.GetWorkingConnection())
                {
                    var query = $"INSERT INTO {tableName} (MovieId, PersonId) VALUES (@MovieId, @PersonId)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MovieId", movieId);
                        command.Parameters.AddWithValue("@PersonId", id);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            return 0;
        }
        public static List<Person> GetMovieDirectors(string movieId)
        {
            return GetRelationships("MovieDirectors", movieId);
        }

        public static List<Person> GetMovieWriters(string movieId)
        {
            return GetRelationships("MovieWriters", movieId);
        }

        public static List<Person> GetMovieCreators(string movieId)
        {
            return GetRelationships("MovieCreator", movieId);
        }

        private static List<Person> GetRelationships(string tableName, string movieId)
        {
            List<Person> people = new List<Person>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = $@"
                SELECT p.Id, p.Name, p.Image 
                FROM {tableName} AS t
                JOIN Person AS p ON t.PersonId = p.Id 
                WHERE t.MovieId = @MovieId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            people.Add(new Person
                            {
                                Id = reader.GetString("Id"),
                                Name = reader.GetString("Name"),
                                Image = reader.IsDBNull("Image") ? null : reader.GetString("Image")
                            });
                        }
                    }
                }
            }

            return people;
        }
        public static void UpdateMovieRelationships(string movieId, List<string> newPersonIds, string tableName)
        {
            List<string> currentPersonIds = GetRelationships(tableName, movieId).Select(p => p.Id).ToList();
            var idsToAdd = newPersonIds.Except(currentPersonIds).ToList();
            var idsToRemove = currentPersonIds.Except(newPersonIds).ToList();
            int remove_result = 0;
            int insert_result = 0;

            if (idsToRemove.Count > 0)
            {
                remove_result = RemoveOutdatedRelationships(tableName, movieId, idsToRemove);
            }

            if (idsToAdd.Count > 0)
            {
                insert_result = InsertRelationship(tableName, movieId, idsToAdd);
            }
        }
        public static void UpdateMovieCreators(string movieId, List<string> newPersonIds)
        {
            UpdateMovieRelationships(movieId, newPersonIds, "MovieCreator");
        }
        public static void UpdateMovieDirectors(string movieId, List<string> newPersonIds)
        {
            UpdateMovieRelationships(movieId, newPersonIds, "MovieDirectors");
        }
        public static void UpdateMovieWriters(string movieId, List<string> newPersonIds)
        {
            UpdateMovieRelationships(movieId, newPersonIds, "MovieWriters");
        }
        private static int RemoveOutdatedRelationships(string tableName, string movieId, List<string> idsToRemove)
        {
            foreach (var id in idsToRemove)
            {
                var deleteQuery = $@"
            DELETE FROM {tableName}
            WHERE MovieId = @MovieId AND PersonId = @PersonId";

                using (var command = new MySqlCommand(deleteQuery, MySQLServer.GetWorkingConnection()))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);
                    command.Parameters.AddWithValue("@PersonId", id);
                    int result = command.ExecuteNonQuery();

                    return result;
                }
            }
            return 0;
        }
        public static void InsertEpisodeDirector(string episodeId, string personId)
        {
            InsertEpisodePerson("EpisodeDirectors", episodeId, new List<string> { personId });
        }
        public static void InsertEpisodeWriter(string episodeId, string personId)
        {
            InsertEpisodePerson("EpisodeWriters", episodeId, new List<string> { personId });
        }
        public static void InsertEpisodeCreator(string episodeId, string personId)
        {
            InsertEpisodePerson("EpisodeCreator", episodeId, new List<string> { personId });
        }
        public static int InsertEpisodePerson(string tableName, string episodeId, List<string> personIds)
        {
            foreach (var id in personIds)
            {
                using (var connection = MySQLServer.GetWorkingConnection())
                {
                    var query = $"INSERT INTO {tableName} (EpisodeId, PersonId) VALUES (@EpisodeId, @PersonId);";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EpisodeId", episodeId);
                        command.Parameters.AddWithValue("@PersonId", id);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            return 0;
        }
        public static int RemoveOutdatedEpisodePerson(string tableName, string episodeId, List<string> idsToRemove)
        {
            foreach (var id in idsToRemove)
            {
                var deleteQuery = $@"
            DELETE FROM {tableName}
            WHERE EpisodeId = @EpisodeId AND PersonId = @PersonId";

                using (var command = new MySqlCommand(deleteQuery, MySQLServer.GetWorkingConnection()))
                {
                    command.Parameters.AddWithValue("@EpisodeId", episodeId);
                    command.Parameters.AddWithValue("@PersonId", id);
                    int result = command.ExecuteNonQuery();

                    return result;
                }
            }
            return 0;
        }
        public static void UpdateEpisodePerson(string tableName, string episodeId, List<string> newPersonIds)
        {
            List<string> currentPersonIds = GetEpisodePerson(tableName, episodeId).Select(p => p.Id).ToList();
            var idsToAdd = newPersonIds.Except(currentPersonIds).ToList();
            var idsToRemove = currentPersonIds.Except(newPersonIds).ToList();
            int remove_result = 0;
            int insert_result = 0;

            if (idsToRemove.Count > 0)
            {
                remove_result = RemoveOutdatedEpisodePerson(tableName, episodeId, idsToRemove);
            }

            if (idsToAdd.Count > 0)
            {
                insert_result = InsertEpisodePerson(tableName, episodeId, idsToAdd);
            }
        }
        public static void UpdateEpisodeCreators(string episodeId, List<string> newPersonIds)
        {
            UpdateEpisodePerson("EpisodeCreator", episodeId, newPersonIds);
        }
        public static void UpdateEpisodeDirectors(string episodeId, List<string> newPersonIds)
        {
            UpdateEpisodePerson("EpisodeDirectors", episodeId, newPersonIds);
        }
        public static void UpdateEpisodeWriters(string episodeId, List<string> newPersonIds)
        {
            UpdateEpisodePerson("EpisodeWriters", episodeId, newPersonIds);
        }
        public static List<EpisodeDirectors> GetEpisodeDirectors(string episodeId)
        {
            List<EpisodeDirectors> directors = new List<EpisodeDirectors>();
            foreach (var director in GetEpisodePerson("EpisodeDirectors", episodeId))
            {
                directors.Add(new EpisodeDirectors
                {
                    Person = director
                });
            }
            return directors;
        }
        public static List<EpisodeWriters> GetEpisodeWriters(string episodeId)
        {
            List<EpisodeWriters> writers = new List<EpisodeWriters>();
            foreach (var writer in GetEpisodePerson("EpisodeWriters", episodeId))
            {
                writers.Add(new EpisodeWriters
                {
                    Person = writer
                });
            }
            return writers;
        }
        public static List<EpisodeCreator> GetEpisodeCreators(string episodeId)
        {
            List<EpisodeCreator> creators = new List<EpisodeCreator>();
            foreach (var creator in GetEpisodePerson("EpisodeCreator", episodeId))
            {
                creators.Add(new EpisodeCreator
                {
                    Person = creator
                });
            }
            return creators;
        }
        public static List<Person> GetEpisodePerson(string tableName, string episodeId)
        {
            List<Person> people = new List<Person>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = $@"
            SELECT p.Id, p.Name, p.Image 
            FROM {tableName}
            JOIN Person AS p ON {tableName}.PersonId = p.Id 
            WHERE {tableName}.EpisodeId = @EpisodeId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EpisodeId", episodeId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            people.Add(new Person
                            {
                                Id = reader.GetString("Id"),
                                Name = reader.GetString("Name"),
                                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : reader.GetString("Image")
                            });
                        }
                    }
                }
            }
            return people;
        }
        public static void InsertEpisodeGenre(string episodeId, string name)
        {
            InsertEpisodeAttribute("EpisodeGenres", episodeId, name);
        }
        public static void InsertEpisodeKeyword(string episodeId, string name)
        {
            InsertEpisodeAttribute("EpisodeKeywords", episodeId, name);
        }
        public static void InsertEpisodeAttribute(string tableName, string episodeId, string name)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = $"INSERT INTO {tableName} (EpisodeId, Name) VALUES (@EpisodeId, @Name);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EpisodeId", episodeId);
                    command.Parameters.AddWithValue("@Name", name);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateEpisodeAttribute(string tableName, string episodeId, List<string> newAttributes)
        {
            List<string> currentAttributes = GetEpisodeAttributes(tableName, episodeId);
            var attributesToAdd = newAttributes.Except(currentAttributes).ToList();
            var attributesToRemove = currentAttributes.Except(newAttributes).ToList();
            int remove_result = 0;
            int insert_result = 0;

            foreach (var attribute in attributesToAdd)
            {
                InsertEpisodeAttribute(tableName, episodeId, attribute);
            }
            foreach (var attribute in attributesToRemove)
            {
                remove_result = RemoveOutdatedEpisodeAttribute(tableName, episodeId, attribute);
            }
        }
        public static int RemoveOutdatedEpisodeAttribute(string tableName, string episodeId, string name)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = $@"
            DELETE FROM {tableName}
            WHERE EpisodeId = @EpisodeId AND Name = @Name";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EpisodeId", episodeId);
                    command.Parameters.AddWithValue("@Name", name);

                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public static void UpdateEpisodeGenre(string episodeId, List<string> newGenres)
        {
            UpdateEpisodeAttribute("EpisodeGenres", episodeId, newGenres);
        }
        public static void UpdateEpisodeKeyword(string episodeId, List<string> newKeywords)
        {
            UpdateEpisodeAttribute("EpisodeKeywords", episodeId, newKeywords);
        }
        public static List<string> GetEpisodeAttributes(string tableName, string episodeId)
        {
            List<string> attributes = new List<string>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = $"SELECT Name FROM {tableName} WHERE EpisodeId = @EpisodeId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EpisodeId", episodeId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            attributes.Add(reader.GetString("Name"));
                        }
                    }
                }
            }
            return attributes;
        }
        public static List<EpisodeGenres> GetEpisodeGenres(string episodeId)
        {
            List<EpisodeGenres> genres = new List<EpisodeGenres>();
            foreach (var genre in GetEpisodeAttributes("EpisodeGenres", episodeId))
            {
                genres.Add(new EpisodeGenres
                {
                    Name = genre
                });
            }
            return genres;
        }
        public static List<EpisodeKeywords> GetEpisodeKeywords(string episodeId)
        {
            List<EpisodeKeywords> keywords = new List<EpisodeKeywords>();
            foreach (var keyword in GetEpisodeAttributes("EpisodeKeywords", episodeId))
            {
                keywords.Add(new EpisodeKeywords
                {
                    Name = keyword
                });
            }
            return keywords;
        }
        public static void InsertCast(Cast cast)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = "INSERT INTO Cast (EpisodeId, PersonId, CharacterName) VALUES (@EpisodeId, @PersonId, @CharacterName);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EpisodeId", cast.EpisodeId);
                    command.Parameters.AddWithValue("@PersonId", cast.Person.Id);
                    command.Parameters.AddWithValue("@CharacterName", cast.CharacterName);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Cast> GetCast(string episodeId, bool isNeedImage = true)
        {
            List<Cast> castList = new List<Cast>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = @"
            SELECT c.EpisodeId, c.PersonId, c.CharacterName, p.Name, p.Image
            FROM Cast c
            JOIN Person p ON c.PersonId = p.Id
            WHERE c.EpisodeId = @EpisodeId;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EpisodeId", episodeId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            castList.Add(new Cast
                            {
                                //EpisodeId = reader.GetString("EpisodeId"),
                                CharacterName = reader.GetString("CharacterName"),
                                Person = new Person
                                {
                                    Id = reader.GetString("PersonId"),
                                    Name = reader.GetString("Name"),
                                    Image = (reader.IsDBNull(reader.GetOrdinal("Image")) && isNeedImage) ? null : reader.GetString("Image")
                                }
                            });
                        }
                    }
                }
            }
            return castList;
        }
        public static void UpdateCast(string episodeId, List<Cast> casts)
        {
            List<Cast> currentCast = GetCast(episodeId, false);
            List<Cast> castToAdd = new List<Cast>();
            foreach (Cast cast in casts)
            {
                if (!currentCast.Any(c => c.Person.Id == cast.Person.Id && c.CharacterName == cast.CharacterName))
                {
                    castToAdd.Add(new Cast()
                    {
                        EpisodeId = episodeId,
                        CharacterName = cast.CharacterName,
                        Person = new Person()
                        {
                            Id = cast.Person.Id,
                            Name = cast.Person.Name,
                            Image = cast.Person.Image
                        }
                    });
                }
            }
            List<Cast> castToRemove = new List<Cast>();
            foreach (Cast cast in currentCast)
            {
                if (!casts.Any(c => c.Person.Id == cast.Person.Id && c.CharacterName == cast.CharacterName))
                {
                    castToRemove.Add(cast);
                }
            }
            int remove_result = 0;
            int insert_result = 0;
            foreach (Cast cast in castToAdd)
            {
                InsertCast(cast);
            }
            foreach (Cast cast in castToRemove)
            {
                remove_result = RemoveOutdatedCast(episodeId, cast.Person.Id, cast.CharacterName);
            }
        }
        public static int RemoveOutdatedCast(string episodeId, string personId, string characterName)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                var query = @"
            DELETE FROM Cast
            WHERE EpisodeId = @EpisodeId AND PersonId = @PersonId AND CharacterName = @CharacterName";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EpisodeId", episodeId);
                    command.Parameters.AddWithValue("@PersonId", personId);
                    command.Parameters.AddWithValue("@CharacterName", characterName);

                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public static List<Cast> GetCastDetailsByMovieId(string movieId)
        {
            string query = @"
        SELECT 
            p.Id AS PersonId, 
            p.Name AS ActorName, 
            p.Image AS ActorImage, 
            c.CharacterName, 
            COUNT(c.EpisodeId) AS EpisodeCount
        FROM 
            Cast c
        JOIN 
            Person p ON c.PersonId = p.Id
        JOIN 
            Episodes e ON c.EpisodeId = e.Id
        WHERE 
            e.MovieId = @MovieId
        GROUP BY 
            p.Id, p.Name, p.Image, c.CharacterName
        ORDER BY 
            p.Name ASC";

            var castDetails = new List<Cast>();

            using (var connection = MySQLServer.GetWorkingConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var person = new Person
                            {
                                Id = reader["PersonId"].ToString(),
                                Name = reader["ActorName"].ToString(),
                                Image = reader["ActorImage"] == DBNull.Value ? null : reader["ActorImage"].ToString()
                            };

                            var cast = new Cast
                            {
                                EpisodeCount = Convert.ToInt32(reader["EpisodeCount"]),
                                CharacterName = reader["CharacterName"].ToString(),
                                Person = person
                            };

                            castDetails.Add(cast);
                        }
                    }
                }
            }

            return castDetails;
        }
        public static List<string> GetGenresByMovieId(string movieId)
        {
            string query = "SELECT GenreName FROM MovieGenres WHERE MovieId = @MovieId";
            var genres = new List<string>();

            using (var connection = MySQLServer.GetWorkingConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genres.Add(reader["GenreName"].ToString());
                        }
                    }
                }
            }

            return genres;
        }
        public static List<Movie> SearchMovie(string? movieName = null, string? contentRating = null, bool? isTVShows = null, List<string>? genres = null, string orderBy = "ReleaseDate", bool isDESC = true, int offset = 0)
        {
            var movies = new List<Movie>();
            using (var connection = MySQLServer.GetWorkingConnection())
            {

                var query = "SELECT * FROM Movies M";
                var conditions = new List<string>();

                if (!string.IsNullOrEmpty(movieName))
                {
                    conditions.Add("M.MovieName LIKE @MovieName");
                }

                if (!string.IsNullOrEmpty(contentRating))
                {
                    conditions.Add("M.ContentRating = @ContentRating");
                }

                if (isTVShows.HasValue)
                {
                    conditions.Add("M.IsTVShows = @IsTVShows");
                }

                if (genres != null && genres.Count > 0)
                {
                    query += " JOIN MovieGenres G ON M.MovieId = G.MovieId";
                    conditions.Add("G.GenreName IN (@Genres)");
                }

                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                query += $" ORDER BY M.{orderBy} {(isDESC ? "DESC" : "ASC")} LIMIT 10 OFFSET @Offset";

                using (var command = new MySqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(movieName))
                    {
                        command.Parameters.AddWithValue("@MovieName", "%" + movieName + "%");
                    }

                    if (!string.IsNullOrEmpty(contentRating))
                    {
                        command.Parameters.AddWithValue("@ContentRating", contentRating);
                    }

                    if (isTVShows.HasValue)
                    {
                        command.Parameters.AddWithValue("@IsTVShows", isTVShows.Value);
                    }

                    if (genres != null && genres.Count > 0)
                    {
                        command.Parameters.AddWithValue("@Genres", string.Join(",", genres));
                    }

                    command.Parameters.AddWithValue("@Offset", offset);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var movie = new Movie
                            {
                                MovieId = reader["MovieId"].ToString(),
                                MovieName = reader["MovieName"].ToString(),
                                ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]),
                                Duration = Convert.ToInt32(reader["Duration"]),
                                ContentRating = reader["ContentRating"].ToString(),
                                IMDbScore = Convert.ToDouble(reader["IMDbScore"]),
                                RatingCount = Convert.ToInt32(reader["RatingCount"]),
                                PosterURL = reader["PosterURL"].ToString(),
                                BackgroundURL = reader["BackgroundURL"].ToString(),
                                TrailerURL = reader["TrailerURL"].ToString(),
                                Description = reader["Description"].ToString(),
                                TotalViews = reader["TotalViews"] != DBNull.Value ? (int?)Convert.ToInt32(reader["TotalViews"]) : null,
                                TotalEpisodes = reader["TotalEpisodes"] != DBNull.Value ? (int?)Convert.ToInt32(reader["TotalEpisodes"]) : null,
                                CurrentEpisodes = reader["CurrentEpisodes"] != DBNull.Value ? (int?)Convert.ToInt32(reader["CurrentEpisodes"]) : null,
                                IMDbEpisodes = reader["IMDbEpisodes"] != DBNull.Value ? (int?)Convert.ToInt32(reader["IMDbEpisodes"]) : null,
                                TotalReviews = reader["TotalReviews"] != DBNull.Value ? (int?)Convert.ToInt32(reader["TotalReviews"]) : null,
                                RatingRatio = reader["RatingRatio"] != DBNull.Value ? (double?)Convert.ToDouble(reader["RatingRatio"]) : null,
                                IsTVShows = Convert.ToBoolean(reader["IsTVShows"])
                            };
                            movies.Add(movie);
                        }
                    }
                }
            }

            return movies;
        }
        public class Search
        {
            public string? MovieName { get; set; }
            public string? ContentRating { get; set; }
            public bool? IsTVShows { get; set; }
            public List<string>? Genres { get; set; }
            public string OrderBy { get; set; } = "ReleaseDate";
            public bool IsDESC { get; set; } = true;
        }
        public class Movie
        {
            public string MovieId { get; set; }
            public string MovieName { get; set; }
            public DateTime ReleaseDate { get; set; }
            public int Duration { get; set; }
            public string ContentRating { get; set; }
            public double IMDbScore { get; set; }
            public int RatingCount { get; set; }
            public string PosterURL { get; set; }
            public string? BackgroundURL { get; set; }
            public string? TrailerURL { get; set; }
            public string Description { get; set; }
            public int? TotalViews { get; set; }
            public int? TotalEpisodes { get; set; }
            public int? CurrentEpisodes { get; set; }
            public int? IMDbEpisodes { get; set; }
            public int? TotalReviews { get; set; }
            public double? RatingRatio { get; set; }
            public bool IsTVShows { get; set; }
        }
        public class Episodes
        {
            public List<Cast>? Casts { get; set; }
            public List<EpisodeCreator>? Creators { get; set; }
            public List<EpisodeDirectors>? Directors { get; set; }
            public List<EpisodeWriters>? Writers { get; set; }
            public List<EpisodeGenres>? Genres { get; set; }
            public List<EpisodeKeywords>? Keywords { get; set; }
            public string Id { get; set; }
            public string MovieId { get; set; }
            public string Season { get; set; }
            public string? Episode { get; set; }
            public DateTime? ReleaseDate { get; set; }
            public int? Duration { get; set; }
            public string? Image { get; set; }
            public string? ImageCaption { get; set; }
            public string? Title { get; set; }
            [JsonProperty("Plot")]
            public string? Plot { get; set; }
            public double? AggregateRating { get; set; }
            public int? VoteCount { get; set; }
        }
        public class Person
        {
            public string Id { get; set; }
            public string? Name { get; set; }
            public string? Image { get; set; }
        }
        public class Cast
        {
            public string? EpisodeId { get; set; }
            public Person Person { get; set; }
            public string CharacterName { get; set; }
            public int EpisodeCount { get; set; }
        }

        public class MovieDirectors
        {
            public string? MovieId { get; set; }
            public string PersonId { get; set; }
        }
        public class MovieWriters
        {
            public string? MovieId { get; set; }
            public string PersonId { get; set; }
        }
        public class MovieCreator
        {
            public string? MovieId { get; set; }
            public string PersonId { get; set; }
        }
        public class EpisodeDirectors
        {
            public string? MovieId { get; set; }
            public Person Person { get; set; }
        }
        public class EpisodeWriters
        {
            public string? MovieId { get; set; }
            public Person Person { get; set; }
        }
        public class EpisodeCreator
        {
            public string? MovieId { get; set; }
            public Person Person { get; set; }
        }
        public class EpisodeGenres
        {
            public string? EpisodeId { get; set; }
            public string Name { get; set; }
        }

        public class EpisodeKeywords
        {
            public string? EpisodeId { get; set; }
            public string Name { get; set; }
        }
        public class Season
        {
            public string? MovieId { get; set; }
            public string Name { get; set; }
        }

    }
}
