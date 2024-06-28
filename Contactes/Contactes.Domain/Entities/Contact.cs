using Contactes.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Contactes.Domain.Entities
{
    public class Contact : BaseEntity
    {
        //[Key]
        //public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<ContactAppointment> ContactAppointments { get; set; }

    }
}
