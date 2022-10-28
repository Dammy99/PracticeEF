using bART.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
