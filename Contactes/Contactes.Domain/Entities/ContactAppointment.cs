using Contactes.Domain.Base;

namespace Contactes.Domain.Entities
{
    public class ContactAppointment : BaseEntity
    {
        public int AppointmentId { get; set; }
        public int ContactId { get; set; }
        public Appointment Appointment { get; set; }
        public Contact Contact { get; set; }
    }
}
