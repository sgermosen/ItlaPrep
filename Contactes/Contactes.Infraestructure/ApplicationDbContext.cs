﻿using Contactes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
