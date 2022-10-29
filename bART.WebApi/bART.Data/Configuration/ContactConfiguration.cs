using bART.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Configuration
{
    static class ContactConfiguration
    {
        public static void Configure(EntityTypeBuilder<Contact> entity)
        {
            //entity.Property(x => x.Email)
            entity.HasKey(x => x.Email);
        }
    }
}
