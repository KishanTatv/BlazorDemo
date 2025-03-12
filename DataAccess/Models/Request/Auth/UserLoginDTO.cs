using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Client.Models.Request.Auth
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
