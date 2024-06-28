using System.ComponentModel.DataAnnotations;

namespace Contactes.Web.ViewModel.Contact
{
    public class BaseContactViewModel
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
