using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ECommerceNet7.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceNet7.Persistence
{
    public static  class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection service)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..\\ResumeProject.Web"));
            configurationManager.AddJsonFile("appsettings.json");
            service.AddDbContext<ECommerceContext>(options => options.UseSqlServer(configurationManager.GetConnectionString("SqlServer")));

        }
    }
}
