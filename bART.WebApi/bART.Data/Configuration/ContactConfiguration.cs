using bART.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
