using bART.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bART.Data.Configuration
{
    static class AccountConfiguration
    {
        public static void Configure(EntityTypeBuilder<Account> entity)
        {
            entity.HasKey(x => x.AccountName);

            entity.HasMany(x => x.Contacts)
                .WithOne(e => e.Account)
                .HasForeignKey(y => y.AccountName);
        }
    }
}
