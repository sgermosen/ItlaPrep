using Contactes.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Contactes.Web.Models
{
    public class AppointmentModel
    { 
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ContactAppointment> ContactAppointments { get; set; }
    }
}
