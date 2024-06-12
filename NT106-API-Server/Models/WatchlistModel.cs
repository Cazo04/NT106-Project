using MySql.Data.MySqlClient;
using NT106_WebServer;

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
    }
}
