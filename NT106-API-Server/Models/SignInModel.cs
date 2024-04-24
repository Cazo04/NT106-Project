using System.ComponentModel.DataAnnotations;

namespace NT106_WebServer.Models
{
    public class SignInModel
    {

        [Required(ErrorMessage = "Please enter your username or email address.")]
        public string UsernameOrEmail { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

}
