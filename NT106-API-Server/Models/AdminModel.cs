using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using NT106_API_Server;

namespace NT106_WebServer.Models
{
    public class AdminModel 
    {
        public string Username { get; set; }
        private string _password;
        public string Password 
        { 
            set { _password = UserModel.HashPassword(value); }
        }
        public int Role { get; set; }

        public AdminToken TempAdminToken { get; set; }

        public void InsertCsAdmin()
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "INSERT INTO CsAdmin (Username, Password, Role) VALUES (@Username, @Password, @Role)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", _password);
                    command.Parameters.AddWithValue("@Role", Role);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void InsertAdminToken(AdminToken token)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "INSERT INTO AdminToken (AdminId, Token, Expires, IsRevoked) VALUES (@AdminId, @Token, @Expires, @IsRevoked)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminId", token.AdminId);
                    command.Parameters.AddWithValue("@Token", token.Token);
                    command.Parameters.AddWithValue("@Expires", token.Expires);
                    command.Parameters.AddWithValue("@IsRevoked", token.IsRevoked);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static AdminToken? GetAdminTokenByAdminId(string adminId)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "SELECT AdminId, Token, Expires, IsRevoked FROM AdminToken WHERE AdminId = @AdminId";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminId", adminId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AdminToken
                            {
                                AdminId = reader.GetString("AdminId"),
                                Token = reader.GetString("Token"),
                                Expires = reader.GetDateTime("Expires"),
                                IsRevoked = reader.GetBoolean("IsRevoked")
                            };
                        }
                    }
                }
            }
            return null; 
        }
        public static AdminToken? GetAdminTokenByToken(string token)
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "SELECT AdminId, Token, Expires, IsRevoked FROM AdminToken WHERE Token = @Token";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Token", token);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AdminToken
                            {
                                AdminId = reader.GetString("AdminId"),
                                Token = reader.GetString("Token"),
                                Expires = reader.GetDateTime("Expires"),
                                IsRevoked = reader.GetBoolean("IsRevoked")
                            };
                        }
                    }
                }
            }
            return null;
        }
        public bool SignIn(SignInModel model)
        {
            Username = model.UsernameOrEmail;
            Password = model.Password;
            return CheckPassword();
        }   
        public bool CheckPassword()
        {
            using (var connection = MySQLServer.GetWorkingConnection())
            {
                const string query = "SELECT Role FROM CsAdmin WHERE Username = @Username AND Password = @Password";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", _password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Role = reader.GetInt32("Role");
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static TokenStatus VerifyRefreshToken(string token)
        {
            var refreshToken = GetAdminTokenByToken(token);

            if (refreshToken == null)
            {
                return TokenStatus.NotExist;
            }

            if (refreshToken.Expires < DateTime.UtcNow)
            {
                return TokenStatus.Expired;
            }

            if (refreshToken.IsRevoked)
            {
                return TokenStatus.Revoked;
            }

            return TokenStatus.OK;
        }
        public TokenStatus VerifyRefreshTokenByAdminId(string adminId)
        {
            var refreshToken = GetAdminTokenByAdminId(adminId);

            if (refreshToken == null)
            {
                return TokenStatus.NotExist;
            }

            TempAdminToken = refreshToken;

            if (refreshToken.Expires < DateTime.UtcNow)
            {
                return TokenStatus.Expired;
            }

            if (refreshToken.IsRevoked)
            {
                return TokenStatus.Revoked;
            }

            return TokenStatus.OK;
        }
    }
    public class AdminToken
    {
        public string AdminId { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsRevoked { get; set; }
    }
}
