using bART.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Context
{
    public interface IBartContext
    {
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public EntityEntry Entry(object entity);
        //public DbSet<Contact> Contacts { get; set; }

    }
}
