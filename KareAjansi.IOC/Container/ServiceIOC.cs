using KareAjansi.BLL.AbstractRepositories;
using KareAjansi.BLL.AbstractServices;
using KareAjansi.BLL.AutoMapper;
using KareAjansi.BLL.Concretes;
using KareAjansi.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.IOC.Container
{
    public class ServiceIOC
    {
        public static void ServiceConfigure(IServiceCollection services) 
        {
            //Dependency Injection
            services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IMankenService, MankenService>();
            services.AddScoped<IOrganizasyonService, OrganizasyonService>();
            services.AddScoped<IOrganizasyonMankenService, OrganizasyonMankenService>();
            services.AddScoped<IOdemeService, OdemeService>();
            services.AddScoped<IYorumService, YorumService>();

            //AutoMapper 
            services.AddAutoMapper(typeof(AutoMapperConfig));
        }
    }
}