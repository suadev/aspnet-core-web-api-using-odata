using Microsoft.EntityFrameworkCore;
using OData.WebApi.Data.TypeConfigurations;

namespace OData.WebApi.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> dbOptions)
            : base(dbOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductTypeConfiguration());
            builder.ApplyConfiguration(new ProductCategoryTypeConfiguration());
        }
    }
}