using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactWeb.Models;

namespace ContactWeb.Data
{
    public class ContactWebContext : DbContext
    {
        public ContactWebContext (DbContextOptions<ContactWebContext> options)
            : base(options)
        {
        }

        public DbSet<ContactWeb.Models.Contact> Contact { get; set; }
    }
}
