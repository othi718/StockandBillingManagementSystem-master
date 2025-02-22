using System.ComponentModel.DataAnnotations;

namespace Business.Form
{
    public class UserLoginForm
    {
        [Required]
        public string? Email { get; set; }
        [Required, MinLength(8)]
        public string? Password { get; set; }
    }
}