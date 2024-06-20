using Contactes.Web.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace Contacts.Application.Dtos.Contact
{
    public class UpdateContactDto: BaseContactDto
    { 
        public int Id { get; set; }

        //[MaxLength(50)]
        //[Required]
        //public string Name { get; set; }

        //[MaxLength(50)]
        //[EmailAddress]
        //public string Email { get; set; }
        //public string PhoneNumber { get; set; }
    }
}
