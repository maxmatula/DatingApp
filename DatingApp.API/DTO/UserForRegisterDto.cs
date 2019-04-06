using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTO
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 12 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}