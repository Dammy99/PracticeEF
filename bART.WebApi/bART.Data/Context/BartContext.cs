using bART.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using bART.Data.Configuration;

namespace bART.Data.Context
{
    public class BartContext : DbContext, IBartContext
    {
        public BartContext(DbContextOptions<BartContext> options)
            : base(options) { }
        public DbSet<Incident> Incidents { get; set; } = null!;
        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;


        //public DbSet<Contact> Contacts { get; set; } = null!;



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("BartConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Incident>(IncidentConfiguration.Configure);
            modelBuilder.Entity<Account>(AccountConfiguration.Configure);
            modelBuilder.Entity<Contact>(ContactConfiguration.Configure);
        }

    }
}
