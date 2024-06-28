using System.ComponentModel.DataAnnotations;

namespace Contactes.Web.ViewModel
{
    public class BaseAppointmentViewModel
    {
        [MaxLength(50)] public string Title { get; set; }
        [MaxLength(500)] public string Description { get; set; }
    }
}
