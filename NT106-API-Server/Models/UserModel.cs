using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace NT106_WebServer.Models
{
    public class UserModel
    {
        public string? Id { get; set; }
        public string Username { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        private string? _passwordHash;
        public string? Password
        {
            set { _passwordHash = HashPassword(value); }
        }
        public string? SMS { get; set; }
        public string? Token { get; set; }
        public int? ReviewNum { get; set; }
        public double? ReputationRatio { get; set; }
        public string? Status { get; set; }
        public string? Avatar { get; set; }

        public UserModel()
        {
            SMS = string.Empty;
            Token = string.Empty;
            ReviewNum = 0;
            ReputationRatio = 0.0;
            Status = "NotActive";
            Avatar = string.Empty;
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public bool IsEmail(string input)
        {
            return Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public bool SignInUser(SignInModel model)
        {
            string query;
            if (IsEmail(model.UsernameOrEmail))
            {
                query = "SELECT Password, Id, Email, Username FROM User WHERE Email = @UsernameOrEmail LIMIT 1";
            }
            else
            {
                query = "SELECT Password, Id, Email, Username FROM User WHERE Username = @UsernameOrEmail LIMIT 1";
            }

            return CheckPassword(query, model.UsernameOrEmail, model.Password);
        }
        private bool CheckPassword(string query, string usernameOrEmail, string password)
        {
            using (var conn = MySQLServer.GetWorkingConnection())
            {
                try
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UsernameOrEmail", usernameOrEmail);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string passwordHash = reader.GetString("Password");
                                Id = reader.GetString("Id");
                                Email = reader.GetString("Email");
                                Username = reader.GetString("Username");
                                return passwordHash == HashPassword(password);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"CheckPassword: {ex.Message}");
                }
            }
            return false;
        }
        public void SignUpUser()
        {
            using (var conn = MySQLServer.GetWorkingConnection())
            {
                try
                {
                    var query = "INSERT INTO User (Username, FullName, Email, DateOfBirth, Password, Status) VALUES (@Username, @FullName, @Email, @DateOfBirth, @Password, @Status)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@FullName", FullName);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        cmd.Parameters.AddWithValue("@Password", _passwordHash);
                        cmd.Parameters.AddWithValue("@Status", "NotActive");

                        cmd.ExecuteNonQuery();
                        //Console.WriteLine("User inserted successfully.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"SignUpUser: {ex.Message}");
                }
            }
        }
        public static UserModel? GetVeryBasicUserByToken(string token)
        {
            using (var conn = MySQLServer.GetWorkingConnection())
            {
                try
                {
                    var query = "SELECT Id, Username FROM User WHERE Id = (SELECT UserId FROM UserToken WHERE Token = @Token)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Token", token);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserModel
                                {
                                    Id = reader.GetString("Id"),
                                    Username = reader.GetString("Username")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"GetVeryBasicUserByToken: {ex.Message}");
                }
            }
            return null;
        }
        public static UserModel? GetUser(string id)
        {
            using (var conn = MySQLServer.GetWorkingConnection())
            {
                try
                {
                    var query = "SELECT Id, Username, FullName, Email, DateOfBirth, SMS, Avatar FROM User WHERE Id = @Id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserModel
                                {
                                    Id = reader.GetString("Id"),
                                    Username = reader.GetString("Username"),
                                    FullName = reader.IsDBNull(reader.GetOrdinal("FullName")) ? null : reader.GetString("FullName"),
                                    Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString("Email"),
                                    DateOfBirth = reader.IsDBNull(reader.GetOrdinal("DateOfBirth")) ? null : reader.GetDateTime("DateOfBirth"),
                                    SMS = reader.IsDBNull(reader.GetOrdinal("SMS")) ? null : reader.GetString("SMS"),
                                    Avatar = reader.IsDBNull(reader.GetOrdinal("Avatar")) ? null : reader.GetString("Avatar")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"GetUser: {ex.Message}");
                }
            }
            return null;
        }
        public static bool ChangePassword(string id, string oldPassword, string newPassword)
        {
            var query = "SELECT Password FROM User WHERE Id = @Id";
            try
            {
                using (var cmd = new MySqlCommand(query, MySQLServer.GetWorkingConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string passwordHash = reader.GetString("Password");
                            if (passwordHash == HashPassword(oldPassword))
                            {
                                query = "UPDATE User SET Password = @Password WHERE Id = @Id";
                                reader.Close();
                                cmd.CommandText = query;
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.Parameters.AddWithValue("@Password", HashPassword(newPassword));
                                cmd.ExecuteNonQuery();
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"ChangePassword: {ex.Message}");
            }
            return false;
        }
        public static void ChangePassword(string id, string newPassword)
        {
            var query = "UPDATE User SET Password = @Password WHERE Id = @Id";
            try
            {
                using (var cmd = new MySqlCommand(query, MySQLServer.GetWorkingConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Password", HashPassword(newPassword));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"ChangePassword: {ex.Message}");
            }
        }

        public static void UpdateUser(UserModel user)
        {
            var query = "UPDATE User SET Username = @Username, FullName = @FullName, Email = @Email, DateOfBirth = @DateOfBirth, SMS = @SMS, Avatar = @Avatar WHERE Id = @Id";
            try
            {
                using (var cmd = new MySqlCommand(query, MySQLServer.GetWorkingConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    cmd.Parameters.AddWithValue("@SMS", user.SMS);
                    cmd.Parameters.AddWithValue("@Avatar", user.Avatar);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"UpdateUser: {ex.Message}");
            }
        }
        public static List<UserModel> GetUsers(int offfset = 0, int limit = 50)
        {
            var users = new List<UserModel>();
            var query = "SELECT Id, Username, FullName, Email, DateOfBirth, SMS, Avatar, ReviewNum FROM User LIMIT @Offset, @Limit";
            try
            {
                using (var cmd = new MySqlCommand(query, MySQLServer.GetWorkingConnection()))
                {
                    cmd.Parameters.AddWithValue("@Offset", offfset);
                    cmd.Parameters.AddWithValue("@Limit", limit);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new UserModel
                            {
                                Id = reader.GetString("Id"),
                                Username = reader.GetString("Username"),
                                FullName = reader.IsDBNull(reader.GetOrdinal("FullName")) ? null : reader.GetString("FullName"),
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString("Email"),
                                DateOfBirth = reader.IsDBNull(reader.GetOrdinal("DateOfBirth")) ? null : reader.GetDateTime("DateOfBirth"),
                                SMS = reader.IsDBNull(reader.GetOrdinal("SMS")) ? null : reader.GetString("SMS"),
                                Avatar = reader.IsDBNull(reader.GetOrdinal("Avatar")) ? null : reader.GetString("Avatar"),
                                ReviewNum = reader.IsDBNull(reader.GetOrdinal("ReviewNum")) ? null : reader.GetInt32("ReviewNum")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"GetUsers: {ex.Message}");
            }
            return users;
        }
    }
}
