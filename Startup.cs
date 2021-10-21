
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.EntityFrameworkCore;
using ecom.database.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System. Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MySQL.Data.EntityFrameworkCore;
using ecom.Repository;

namespace ecom
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
            var connectionString = Configuration["DbConnectionString"];
            services.AddEntityFrameworkMySql().AddDbContext<MySqlDbContext>(options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 11))));
        
            services.AddMvc(MvcOptions => MvcOptions.EnableEndpointRouting = false);
            services.AddControllers();
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<IItemRepository, ItemRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
