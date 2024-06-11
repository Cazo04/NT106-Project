using System.ComponentModel.DataAnnotations;

namespace NT106_WebServer.Models
{
    public class ChangePasswordModel
    {
        public string? UserId { get; set; }
        [Required(ErrorMessage = "Please enter your old password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Please enter your new password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string NewPassword { get; set; }
    }
}
