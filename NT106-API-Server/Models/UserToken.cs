namespace NT106_WebServer.Models
{
    public class UserToken
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsRevoked { get; set; }
    }
}
