using System.ComponentModel.DataAnnotations;

namespace Contacts.Application.Dtos.Contact
{
    public class BaseContactDto
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
