using System.ComponentModel.DataAnnotations;

namespace SMS.DataAccess.Models.Auth.Request
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }


    public class UserPhoto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
