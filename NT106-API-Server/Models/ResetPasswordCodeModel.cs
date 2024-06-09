using MySql.Data.MySqlClient;
using NT106_WebServer;
using NT106_WebServer.Models;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace NT106_API_Server.Models
{
    public class ResetPasswordCodeModel
    {
        public string Email { get; set; }
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        public static string? GetUserIdByEmail(string email)
        {
            string? userId = null;

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = "SELECT Id FROM User WHERE Email = @Email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = reader["Id"].ToString();
                        }
                    }
                }
            }

            return userId;
        }
        public static bool DoesUserIdHaveCode(string email)
        {
            bool hasCode = false;
            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = "SELECT COUNT(*) FROM ResetPasswordCode WHERE UserId = (SELECT Id FROM User WHERE Email = @Email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    hasCode = count > 0;
                }
            }
            return hasCode;
        }
        public static void InsertResetPasswordCode(string email, string code)
        {

            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = @"
                INSERT INTO ResetPasswordCode (UserId, Code, CreatedDate)
                VALUES ((SELECT Id FROM User WHERE Email = @Email), @Code, @CreatedDate)
                ON DUPLICATE KEY UPDATE
                Code = VALUES(Code),
                CreatedDate = VALUES(CreatedDate)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Code", code);
                    command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }

        }
        public static void UpdateResetPasswordCode(string userId, string newCode)
        {
            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = "UPDATE ResetPasswordCode SET Code = @NewCode, CreatedDate = @NewCreatedDate WHERE UserId = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@NewCode", newCode);
                    command.Parameters.AddWithValue("@NewCreatedDate", DateTime.Now);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public class CodeValid
        {
            public bool IsValid { get; set; }
            public TimeSpan TimeLeft { get; set; }
        }
        public static CodeValid? IsCodeValidWithinOneMinute(string email)
        {
            CodeValid? codeValid = null;
            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = "SELECT CreatedDate FROM ResetPasswordCode WHERE UserId = (SELECT Id FROM User WHERE Email = @Email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime createdDate = reader.GetDateTime("CreatedDate");
                            codeValid = new CodeValid();
                            codeValid.IsValid = (DateTime.Now - createdDate).TotalMinutes <= 1;
                            codeValid.TimeLeft = TimeSpan.FromMinutes(1) - (DateTime.Now - createdDate);
                        }
                    }
                }
            }
            return codeValid;
        }
        public static bool IsCodeValidWithinFiveMinutes(string email)
        {
            bool isValid = false;
            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = "SELECT CreatedDate FROM ResetPasswordCode WHERE UserId = (SELECT Id FROM User WHERE Email = @Email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime createdDate = reader.GetDateTime("CreatedDate");
                            if ((DateTime.Now - createdDate).TotalMinutes <= 5)
                            {
                                isValid = true;
                            }
                            else
                            {
                                DeleteResetPasswordCode(email);
                            }
                        }
                    }
                }
            }
            return isValid;
        }
        public static bool IsCodeMatch(string email, string code)
        {
            bool isMatch = false;
            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = "SELECT Code FROM ResetPasswordCode WHERE UserId = (SELECT Id FROM User WHERE Email = @Email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string dbCode = reader.GetString("Code");
                            isMatch = dbCode == code;
                        }
                    }
                }
            }
            return isMatch;
        }
        private static void DeleteResetPasswordCode(string email)
        {
            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = "DELETE FROM ResetPasswordCode WHERE UserId = (SELECT Id FROM User WHERE Email = @Email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void SendEmail(string toMail, string code)
        {
            string fromMail = "22520621@gm.uit.edu.vn";
            string fromPassword = "eglycumtihnjdken";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.To.Add(new MailAddress(toMail));
            message.Subject = "Reset Password";
            message.Body = "Your reset password code: " + code + "\nValid for 5 minutes";

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential(fromMail, fromPassword),
                EnableSsl = true
            };
            client.Send(message);
        }
        public class CodeGenerator
        {
            private static readonly char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
            private static readonly Random random = new Random();

            public static string GenerateRandomCode(int length)
            {
                StringBuilder result = new StringBuilder(length);
                for (int i = 0; i < length; i++)
                {
                    result.Append(chars[random.Next(chars.Length)]);
                }
                return result.ToString();
            }
        }
        public static void ResetPassword(string email, string password)
        {
            using (MySqlConnection connection = MySQLServer.GetWorkingConnection())
            {
                string query = "UPDATE User SET Password = @Password WHERE Email = @Email";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", UserModel.HashPassword(password));
                    command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
