using bART.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bART.Data.Configuration
{
    static class IncidentConfiguration
    {
        public static void Configure(EntityTypeBuilder<Incident> entity)
        {
            entity.HasKey(p => new { p.IncidentName });

            entity.Property(p => p.IncidentName).ValueGeneratedOnAdd();

            //entity.Property(p => p.IncidentName).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            entity.HasMany(c => c.Accounts)
                  .WithOne(e => e.Incident)
                  .HasForeignKey(f => f.IncidentName);
        }
    }
}
