using bART.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace bART.Data.Context
{
    public interface IBartContext
    {
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public EntityEntry Entry(object entity);
    }
}
