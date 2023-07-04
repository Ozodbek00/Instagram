using System.ComponentModel.DataAnnotations;

namespace Instagram.Api.Service.DTOs
{
    public class UserForCreationDto
    {
        [MaxLength(32)]
        public string FirstName { get; set; }

        [MaxLength(32)]
        public string LastName { get; set; }

        [MaxLength(16)]
        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Password { get; set; }

        public string Nickname { get; set; }
    }
}
