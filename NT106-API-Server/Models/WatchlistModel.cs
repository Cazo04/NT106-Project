using MySql.Data.MySqlClient;
using NT106_WebServer;
using NT106_WebServer.Models;
using static NT106_WebServer.Models.MovieModel;

namespace NT106_API_Server.Models
{
    public class WatchlistModel
    {
        public string UserId { get; set; }
        public string EpisodeId { get; set; }

        public static void InsertWatchlist(string userId, string episodeId)
        {
            using (MySqlConnection conn = MySQLServer.GetWorkingConnection())
            {
                string query = "INSERT INTO Watchlist (UserId, EpisodeId) VALUES (@UserId, @EpisodeId)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@EpisodeId", episodeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteWatchlist(string userId, string episodeId)
        {
            using (MySqlConnection conn = MySQLServer.GetWorkingConnection())
            {
                string query = "DELETE FROM Watchlist WHERE UserId = @UserId AND EpisodeId = @EpisodeId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@EpisodeId", episodeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<string> GetUserWatchlist(string userId)
        {
            List<string> watchlist = new List<string>();
            using (MySqlConnection conn = MySQLServer.GetWorkingConnection())
            {
                string query = "SELECT EpisodeId FROM Watchlist WHERE UserId = @UserId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            watchlist.Add(reader.GetString("EpisodeId"));
                        }
                    }
                }
            }
            return watchlist;
        }
        public static bool IsEpisodeInWatchlist(string userId, string episodeId)
        {
            using (MySqlConnection conn = MySQLServer.GetWorkingConnection())
            {
                string query = "SELECT COUNT(*) FROM Watchlist WHERE UserId = @UserId AND EpisodeId = @EpisodeId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@EpisodeId", episodeId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public static List<MovieModel> GetMoviesFromUserWatchlist(string userId, int limit = 10)
        {
            List<MovieModel> movies = new List<MovieModel>();

            using (MySqlConnection conn = MySQLServer.GetWorkingConnection())
            {
                try
                {
                    string query = $@"
                SELECT m.*
                FROM Movies m
                WHERE m.MovieId IN (
                    SELECT e.MovieId
                    FROM Episodes e
                    WHERE e.Id IN (
                        SELECT w.EpisodeId
                        FROM Watchlist w
                        WHERE w.UserId = @UserId
                    )
                )
                LIMIT @Limit";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Limit", limit);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Movie movie = new Movie
                                {
                                    MovieId = reader["MovieId"].ToString(),
                                    MovieName = reader["MovieName"].ToString(),
                                    ReleaseDate = reader.GetDateTime("ReleaseDate"),
                                    Duration = reader.GetInt32("Duration"),
                                    ContentRating = reader["ContentRating"].ToString(),
                                    IMDbScore = reader.GetDouble("IMDbScore"),
                                    RatingCount = reader.GetInt32("RatingCount"),
                                    PosterURL = reader["PosterURL"].ToString(),
                                    //BackgroundURL = reader.IsDBNull(reader.GetOrdinal("BackgroundURL")) ? null : reader["BackgroundURL"].ToString(),
                                    TrailerURL = reader.IsDBNull(reader.GetOrdinal("TrailerURL")) ? null : reader["TrailerURL"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    //TotalViews = reader.IsDBNull(reader.GetOrdinal("TotalViews")) ? (int?)null : reader.GetInt32("TotalViews"),
                                    //TotalEpisodes = reader.IsDBNull(reader.GetOrdinal("TotalEpisodes")) ? (int?)null : reader.GetInt32("TotalEpisodes"),
                                    //CurrentEpisodes = reader.IsDBNull(reader.GetOrdinal("CurrentEpisodes")) ? (int?)null : reader.GetInt32("CurrentEpisodes"),
                                    //IMDbEpisodes = reader.IsDBNull(reader.GetOrdinal("IMDbEpisodes")) ? (int?)null : reader.GetInt32("IMDbEpisodes"),
                                    TotalReviews = reader.IsDBNull(reader.GetOrdinal("TotalReviews")) ? (int?)null : reader.GetInt32("TotalReviews"),
                                    //RatingRatio = reader.IsDBNull(reader.GetOrdinal("RatingRatio")) ? (double?)null : reader.GetDouble("RatingRatio"),
                                    IsTVShows = reader.GetBoolean("IsTVShows")
                                };
                                MovieModel model = new MovieModel();
                                model.MovieInfo = movie;
                                model.Genres = MovieModel.GetGenresByMovieId(movie.MovieId);
                                model.Seasons = MovieModel.GetSeasons(movie.MovieId);
                                movies.Add(model);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("GetMoviesFromUserWatchlist: " + ex);
                }
            }


            return movies;
        }
    }
}
