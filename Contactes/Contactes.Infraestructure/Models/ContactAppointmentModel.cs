using Contactes.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Contactes.Web.Models
{
    public class ContactAppointmentModel
    { 
        public int Id { get; set; }

        public int AppointmentId { get; set; }
        public int ContactId { get; set; }
        //TODO: Provocar error con propiedades de navegacion
        //public Appointment Appointment { get; set; }
        //public Contact Contact { get; set; }
    }
}
