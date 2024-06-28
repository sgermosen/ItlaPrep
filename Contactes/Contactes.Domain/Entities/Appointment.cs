using Contactes.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactes.Domain.Entities
{
    public class Appointment: BaseEntity
    {
        [MaxLength(50)] public string Title { get; set; }
        [MaxLength(500)] public string Description { get; set; }
        public List<ContactAppointment> ContactAppointments { get; set; }
    }
}
