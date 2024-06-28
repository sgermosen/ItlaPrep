using System.ComponentModel.DataAnnotations;

namespace Contactes.Web.ViewModel
{
    public class BaseContactAppointmentViewModel
    {
        public int AppointmentId { get; set; }
        public int ContactId { get; set; }
    }
}
