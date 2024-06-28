using System.ComponentModel.DataAnnotations;

namespace Contacts.Application.Dtos.Contact
{
    public class BaseAppointmentDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
