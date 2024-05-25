using Contactes.Web.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Contactes.Web.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
