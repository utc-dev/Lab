using Bics;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lab.Data
{
    class Bootstrap : IBootstrap
    {
        public int Priority => 1000;

        public void Configure(IApplicationBuilder app)
        {
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<LabDataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LabConnection"));
            });
        }
    }
}