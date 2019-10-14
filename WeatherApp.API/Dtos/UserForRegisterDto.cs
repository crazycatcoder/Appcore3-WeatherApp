using System.ComponentModel.DataAnnotations;

namespace WeatherApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="password must be between 4 and 8 characters")]
        public string Password { get; set; }
    }
}