﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using NT106_WebServer;

namespace NT106_API_Server.Models
{
    public class CommentModel
    {
        public string Id { get; set; }
        public string EpisodeId { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [JsonProperty("Content")]
        public string Content { get; set; }
        public int UpVote { get; set; } = 0;
        public int DownVote { get; set; } = 0;

        public static void InsertComment(CommentModel comment)
        {
            string query = @"INSERT INTO Comment (EpisodeId, UserId, CreateDate, Content, UpVote, DownVote)
                         VALUES (@EpisodeId, @UserId, @CreateDate, @Content, @UpVote, @DownVote)";

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EpisodeId", comment.EpisodeId);
                command.Parameters.AddWithValue("@UserId", comment.UserId);
                command.Parameters.AddWithValue("@CreateDate", comment.CreateDate);
                command.Parameters.AddWithValue("@Content", comment.Content);
                command.Parameters.AddWithValue("@UpVote", comment.UpVote);
                command.Parameters.AddWithValue("@DownVote", comment.DownVote);

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
            string query = "SELECT * FROM Comment WHERE EpisodeId = @EpisodeId ORDER BY (UpVote - DownVote) DESC LIMIT @Num";

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
                            DownVote = reader.GetInt32("DownVote")
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
                            DownVote = reader.GetInt32("DownVote")
                        });
                    }
                }
            }

            return comments;
        }
    }
}
