using System.ComponentModel.DataAnnotations;

namespace Contactes.Web.ViewModel.Contact
{
    public class UpdateContactViewModel : BaseContactViewModel
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
