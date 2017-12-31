using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiCoreBooksSample.Domain;
using JsonApiCoreBooksSample.Repository;
using JsonApiDotNetCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JsonApiCoreBooksSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            { // use whatever provider you want, this is just an example
                options.UseSqlite("Data Source=JsonApiCoreSampleData.db");
            }, ServiceLifetime.Transient);

            // add jsonapi dotnet core
            services.AddJsonApi<AppDbContext>(
                options =>
                {
                    options.RelativeLinks = false;
                    options.AllowClientGeneratedIds = true;
                    options.IncludeTotalRecordCount = true;
                }

                );
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, AppDbContext context)
        {
            app.UseJsonApi();
        }
    }
}
