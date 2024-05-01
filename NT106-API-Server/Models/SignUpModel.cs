using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NT106_WebServer.Models
{   
    public class SignUpModel
    {
        [Required(ErrorMessage = "Please enter your full name.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter your date of birth.")]
        [MinimumAge(13, ErrorMessage = "You must be at least 13 years old.")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Please choose a username.")]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "Username must be at least 6 characters long.")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Username must only contain letters, numbers, and underscores.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }

    public class MinimumAgeAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;

        public MinimumAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
            ErrorMessage = "You must be at least {0} years old.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime)
            {
                var dateOfBirth = (DateTime)value;
                var age = DateTime.Today.Year - dateOfBirth.Year;
                if (dateOfBirth > DateTime.Today.AddYears(-age)) age--;

                if (age >= _minimumAge)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(string.Format(ErrorMessage, _minimumAge));
                }
            }

            return new ValidationResult("Invalid date format.");
        }
    }
}
