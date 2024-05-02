using MySql.Data.MySqlClient;
using NT106_WebServer;
using NT106_WebServer.Models;

namespace NT106_API_Server
{
    public class TokenService
    {
        public static string GenerateUUID()
        {
            string uuid = Guid.NewGuid().ToString();
            DateTime now = DateTime.Now;
            long millis = (long)now.TimeOfDay.TotalMilliseconds;
            string timestamp = $"{millis}-{now:dd-MM-yyyy}";
            string randomString = $"{uuid}-{timestamp}";
            return randomString;
        }
        public static string TempToken { get; set; }
        public static bool InsertUserToken(UserToken user)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "INSERT INTO UserToken (UserId, Token, Expires, IsRevoked) VALUES (@UserId, @Token, @Expires, @IsRevoked)";

                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        TempToken = GenerateUUID();
                        command.Parameters.AddWithValue("@UserId", user.UserId);
                        command.Parameters.AddWithValue("@Token", user.Token);
                        command.Parameters.AddWithValue("@Expires", DateTime.Now.AddDays(30));
                        command.Parameters.AddWithValue("@IsRevoked", false);

                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1062)
                        {
                            //Console.WriteLine("A record with the same PRIMARY KEY or UNIQUE value already exists.");
                            return false;
                        }
                        else
                        {
                            throw new Exception($"InsertUserToken: {ex.Message}");
                        }
                    }
                }
            }
        }
        public static void UpdateUserToken(string userId,string newToken)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "UPDATE UserToken SET Token = @Token, Expires = @Expires WHERE UserId = @UserId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Token", newToken);
                    command.Parameters.AddWithValue("@Expires", DateTime.Now.AddDays(30));

                    command.ExecuteNonQuery();
                }
            }
        }
        public static string? GetTokenUserById(string userId)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "SELECT Token FROM UserToken WHERE UserId = @UserId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString("Token");
                        }
                    }
                }
            }
            return null;
        }
        public static TokenStatus GetUserTokenStatus(string token)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "SELECT Expires, IsRevoked FROM UserToken WHERE Token = @Token";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Token", token);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime expires = reader.GetDateTime("Expires");
                            bool isRevoked = reader.GetBoolean("IsRevoked");

                            if (DateTime.Now > expires)
                            {
                                return TokenStatus.Expired;
                            }
                            else if (isRevoked)
                            {
                                return TokenStatus.Revoked;
                            }
                            else
                            {
                                return TokenStatus.OK;
                            }
                        }
                    }
                }
            }
            return TokenStatus.NotExist;
        }
    }
    public enum TokenStatus
    {
        NotExist, 
        Expired, 
        Revoked, 
        OK 
    }
}
