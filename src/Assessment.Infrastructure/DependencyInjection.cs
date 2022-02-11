using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Assessment.Core.Repositories;
using Assessment.Infrastructure.Data;
using Assessment.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Assessment.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AssessmentDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(AssessmentDbContext).Assembly.FullName)));
            services.AddTransient<IBuildingRepository, BuildingRepository>();
            services.AddTransient<IObjectRepository, ObjectRepository>();
            services.AddTransient<IDataFieldRepository, DataFieldRepository>();
            services.AddTransient<IReadingRepository, ReadingRepository>();
            return services;
        }
    }
}
