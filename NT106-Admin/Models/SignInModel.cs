using System.ComponentModel.DataAnnotations;

namespace NT106_WebServer.Models
{
    public class SignInModel
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

}
