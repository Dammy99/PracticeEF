using bART.Data.Context;
using bART.Data.Services.Implementation;
using bART.Data.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace bART.Data.Extentions
{
    public static class DataDI
    {
        public static void AddDomainDataServices(this IServiceCollection services)
        {
            services.AddDbContext<IBartContext, BartContext>();
        }
        public static void AddDI(this IServiceCollection services)
        {
            services.AddScoped<IIncidentService, IncidentService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IContactService, ContactService>();
        }
    }
}
