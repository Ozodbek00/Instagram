using System.ComponentModel.DataAnnotations;

namespace Instagram.Api.Service.DTOs
{
    public class UserForUpdateDto
    {
        [MaxLength(32)]
        public string FirstName { get; set; }

        [MaxLength(32)]
        public string LastName { get; set; }

        [MaxLength(16)]
        public string PhoneNumber { get; set; }
    }
}
