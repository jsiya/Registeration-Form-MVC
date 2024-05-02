using System.ComponentModel.DataAnnotations;

namespace Validation_MVC.Validators.DataAnnotation;


public class UserValidator
{
        [Required(ErrorMessage = "Please enter full name")]
        [RegularExpression(@"^[a-zA-Z]+$", 
                ErrorMessage = "Full Name consists only alphabetical characters")]
        public string FullName { get; set; }
        
        
        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }
        
        
        [Required(ErrorMessage = "Please enter username")]
        [MinLength(4, ErrorMessage = "Username cannot be less than 4 character")]
        public string Username { get; set; }
        
        
        [Required(ErrorMessage = "Please enter password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d\S]{8,}$", 
                ErrorMessage = "Password must be At least 8 characters long.\nContains at least one uppercase letter.\nContains at least one lowercase letter.\nContains at least one digit.\nCan contain alphanumeric characters and some special characters.")]
        public string Password { get; set; }
}