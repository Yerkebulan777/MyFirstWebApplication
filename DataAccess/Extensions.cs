using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAcess(this IServiceCollection services)
        {
            services.AddDbContext<AppContext>(x =>
            {
                x.UseNpgsql(connectionString: "Host=localhost; Database=NoteDb; Username=postgress; Password=12345");
            });

            return services;
        }
    }
}
