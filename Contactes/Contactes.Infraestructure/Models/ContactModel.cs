using System.ComponentModel.DataAnnotations;

namespace Contactes.Web.Models
{
    public class ContactModel
    { 
        public int Id { get; set; } 
        public string Name { get; set; }  
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
