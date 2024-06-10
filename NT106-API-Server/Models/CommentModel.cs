using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using NT106_WebServer;

namespace NT106_API_Server.Models
{
    public class CommentModel
    {
        public string? Id { get; set; }
        public string EpisodeId { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [JsonProperty("Content")]
        public string Content { get; set; }
        public int UpVote { get; set; } = 0;
        public int DownVote { get; set; } = 0;
        public bool IsPositive { get; set; }
        public string? Username { get; set; }
        public string? Avatar { get; set; }
        public int? ReviewNum { get; set; }

        public class Vote
        {
            public string UserId { get; set; }
            public string CommentId { get; set; }
            public bool IsUpVote { get; set; }
        }

        public static void InsertComment(CommentModel comment)
        {
            string query = @"INSERT INTO Comment (EpisodeId, UserId, CreateDate, Content, UpVote, DownVote, IsPositive)
                         VALUES (@EpisodeId, @UserId, @CreateDate, @Content, @UpVote, @DownVote, @IsPositive)";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EpisodeId", comment.EpisodeId);
                command.Parameters.AddWithValue("@UserId", comment.UserId);
                command.Parameters.AddWithValue("@CreateDate", comment.CreateDate);
                command.Parameters.AddWithValue("@Content", comment.Content);
                command.Parameters.AddWithValue("@UpVote", comment.UpVote);
                command.Parameters.AddWithValue("@DownVote", comment.DownVote);
                command.Parameters.AddWithValue("@IsPositive", comment.IsPositive);

                command.ExecuteNonQuery();
            }
        }

        public static bool HasUserCommented(string userId, string episodeId)
        {
            string query = "SELECT * FROM Comment WHERE UserId = @UserId AND EpisodeId = @EpisodeId";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@EpisodeId", episodeId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.Read();
                }
            }
        }
        public static List<CommentModel> GetTopCommentsByEpisodeId(string episodeId, int num = 5)
        {
            List<CommentModel> comments = new List<CommentModel>();
            string query = @"
        SELECT c.*, u.Username, u.Avatar, u.ReviewNum
        FROM Comment c
        JOIN User u ON c.UserId = u.Id
        WHERE c.EpisodeId = @EpisodeId
        ORDER BY (c.UpVote - c.DownVote) DESC
        LIMIT @Num";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EpisodeId", episodeId);
                command.Parameters.AddWithValue("@Num", num);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comments.Add(new CommentModel
                        {
                            Id = reader.GetString("Id"),
                            EpisodeId = reader.GetString("EpisodeId"),
                            UserId = reader.GetString("UserId"),
                            CreateDate = reader.GetDateTime("CreateDate"),
                            Content = reader.GetString("Content"),
                            UpVote = reader.GetInt32("UpVote"),
                            DownVote = reader.GetInt32("DownVote"),
                            IsPositive = reader.GetBoolean("IsPositive"),
                            Username = reader.GetString("Username"),
                            Avatar = reader.IsDBNull(reader.GetOrdinal("Avatar")) ? string.Empty : reader.GetString("Avatar"),
                            ReviewNum = reader.GetInt32("ReviewNum")
                        });
                    }
                }
            }

            return comments;
        }

        public List<CommentModel> GetRecentCommentsByEpisodeId(string episodeId, int num = 5)
        {
            List<CommentModel> comments = new List<CommentModel>();
            string query = "SELECT * FROM Comment WHERE EpisodeId = @EpisodeId ORDER BY CreateDate DESC LIMIT @Num";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EpisodeId", episodeId);
                command.Parameters.AddWithValue("@Num", num);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comments.Add(new CommentModel
                        {
                            Id = reader.GetString("Id"),
                            EpisodeId = reader.GetString("EpisodeId"),
                            UserId = reader.GetString("UserId"),
                            CreateDate = reader.GetDateTime("CreateDate"),
                            Content = reader.GetString("Content"),
                            UpVote = reader.GetInt32("UpVote"),
                            DownVote = reader.GetInt32("DownVote"),
                            IsPositive = reader.GetBoolean("IsPositive")
                        });
                    }
                }
            }

            return comments;
        }
        public List<CommentModel> GetRecentCommentsNotInTopCommentsByEpisodeId(string episodeId, int topNum = 5, int recentNum = 5)
        {
            List<CommentModel> comments = new List<CommentModel>();

            string query = @"
    WITH TopComments AS (
        SELECT c.Id
        FROM Comment c
        WHERE c.EpisodeId = @EpisodeId
        ORDER BY (c.UpVote - c.DownVote) DESC
        LIMIT @TopNum
    )
    SELECT c.*, u.Username, u.Avatar, u.ReviewNum
    FROM Comment c
    JOIN User u ON c.UserId = u.Id
    WHERE c.EpisodeId = @EpisodeId AND c.Id NOT IN (SELECT Id FROM TopComments)
    ORDER BY c.CreateDate DESC
    LIMIT @RecentNum";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EpisodeId", episodeId);
                command.Parameters.AddWithValue("@TopNum", topNum);
                command.Parameters.AddWithValue("@RecentNum", recentNum);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comments.Add(new CommentModel
                        {
                            Id = reader.GetString("Id"),
                            EpisodeId = reader.GetString("EpisodeId"),
                            UserId = reader.GetString("UserId"),
                            CreateDate = reader.GetDateTime("CreateDate"),
                            Content = reader.GetString("Content"),
                            UpVote = reader.GetInt32("UpVote"),
                            DownVote = reader.GetInt32("DownVote"),
                            IsPositive = reader.GetBoolean("IsPositive"),
                            Username = reader.GetString("Username"),
                            Avatar = reader.IsDBNull(reader.GetOrdinal("Avatar")) ? string.Empty : reader.GetString("Avatar"),
                            ReviewNum = reader.GetInt32("ReviewNum")
                        });
                    }
                }
            }

            return comments;
        }
        public static CommentModel? GetComment(string commentId)
        {
            CommentModel? comment = null;
            string query = @"
        SELECT c.*, u.Username, u.ReviewNum 
        FROM Comment c
        INNER JOIN User u ON c.UserId = u.Id
        WHERE c.Id = @Id";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", commentId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        comment = new CommentModel
                        {
                            Id = reader.GetString("Id"),
                            EpisodeId = reader.GetString("EpisodeId"),
                            UserId = reader.GetString("UserId"),
                            CreateDate = reader.GetDateTime("CreateDate"),
                            Content = reader.GetString("Content"),
                            UpVote = reader.GetInt32("UpVote"),
                            DownVote = reader.GetInt32("DownVote"),
                            IsPositive = reader.GetBoolean("IsPositive"),
                            Username = reader.GetString("Username"),
                            ReviewNum = reader.GetInt32("ReviewNum")
                        };
                    }
                }
            }

            return comment;
        }
        public static Vote? GetVoteCommentByCommentIdAndUserId(Vote vote)
        {
            string query = "SELECT * FROM UpVoteComment WHERE CommentId = @CommentId AND UserId = @UserId";

            bool? isUpVote = null;

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CommentId", vote.CommentId);
                command.Parameters.AddWithValue("@UserId", vote.UserId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isUpVote = true;
                    }
                }
            }

            query = "SELECT * FROM DownVoteComment WHERE CommentId = @CommentId AND UserId = @UserId";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CommentId", vote.CommentId);
                command.Parameters.AddWithValue("@UserId", vote.UserId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isUpVote = false;
                    }
                }
            }

            if (isUpVote == null)
            {
                return null;
            }
            vote.IsUpVote = isUpVote.Value;

            return vote;
        }
        public static void AddUpVoteComment(string commentId, string userId)
        {
            string query = "INSERT INTO UpVoteComment (CommentId, UserId) VALUES (@CommentId, @UserId)";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CommentId", commentId);
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }
        public static void AddDownVoteComment(string commentId, string userId)
        {
            string query = "INSERT INTO DownVoteComment (CommentId, UserId) VALUES (@CommentId, @UserId)";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CommentId", commentId);
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }
        public static void RemoveUpVoteComment(string commentId, string userId)
        {
            string query = "DELETE FROM UpVoteComment WHERE CommentId = @CommentId AND UserId = @UserId";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CommentId", commentId);
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }
        public static void RemoveDownVoteComment(string commentId, string userId)
        {
            string query = "DELETE FROM DownVoteComment WHERE CommentId = @CommentId AND UserId = @UserId";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CommentId", commentId);
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }
        public static bool HasUserVotedComment(string commentId, string userId)
        {
            string query = "SELECT * FROM UpVoteComment WHERE CommentId = @CommentId AND UserId = @UserId";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CommentId", commentId);
                command.Parameters.AddWithValue("@UserId", userId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }

            query = "SELECT * FROM DownVoteComment WHERE CommentId = @CommentId AND UserId = @UserId";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CommentId", commentId);
                command.Parameters.AddWithValue("@UserId", userId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}

