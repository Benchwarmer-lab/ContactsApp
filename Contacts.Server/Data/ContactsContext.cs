using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contacts.Server.Models;

namespace Contacts.Server.Data
{
    public class ContactsContext : DbContext
    {
        public ContactsContext (DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; } = default!;
    }
}
