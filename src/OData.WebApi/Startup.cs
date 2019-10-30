using System.Linq;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Formatter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Microsoft.OData.Edm;
using OData.WebApi.Data;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;
using OData.WebApi.Dto;

namespace OData.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProductDbContext>(
                    options => options.UseNpgsql(Configuration.GetConnectionString("ProductConStr")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services
                .AddMvc(options => options.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddOData();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<ProductDbContext>())
                {
                    context.Database.Migrate();
                }
            }

            app.UseMvc(
                routeBuilder =>
                {
                    // routeBuilder.EnableDependencyInjection(); //Enables the non-OData route container.
                    // routeBuilder.Filter().Count().Expand().OrderBy().Select();
                    routeBuilder.MapODataServiceRoute("ODataRoute", "odata", GetEdmModel());
                });
        }

        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EnableLowerCamelCase();

            builder.EntitySet<Product>("products")
                .EntityType.Filter().Count().Expand().OrderBy().Page().Select();

            builder.EntitySet<ProductCategory>("product_categories")
                .EntityType.Filter().Count().Expand().OrderBy().Page().Select();

            return builder.GetEdmModel();
        }
    }
}
