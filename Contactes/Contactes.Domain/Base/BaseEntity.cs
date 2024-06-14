using System.ComponentModel.DataAnnotations;

namespace Contactes.Domain.Base
{
    public class BaseEntity
    {
        [Key] public int Id { get; set; }
    }
}
