using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.DAL.Contexts;
using WorkShopManagement.DAL.Helpers;
using WorkShopManagement.DAL.Repositories.Abstractions;
using WorkShopManagement.DAL.Repositories.Implementations;

namespace WorkShopManagement.DAL.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(
            opt =>
            {
                opt.UseSqlServer(ConnectionStr.GetConnectionString());
            }
        );

        services.AddScoped<IParticipantRepository, ParticipantRepository>();
        services.AddScoped<IWorkShopRepository, WorkShopRepository>();
    }
}
