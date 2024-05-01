
namespace NT106_User.Models
{   
    public class SignUpModel
    {       
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }   
}
