using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OData.WebApi.Data.Entities;

namespace OData.WebApi.Data.TypeConfigurations
{
    public class ProductCategoryTypeConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(
                new ProductCategory
                {
                    Id = Guid.Parse("8b726886-e719-413c-a125-939ee5af387d"),
                    CategoryName = "TV"
                },
                new ProductCategory
                {
                    Id = Guid.Parse("1236a458-0802-4340-bdd4-05859c9aaaad"),
                    CategoryName = "Headphones"
                },
                new ProductCategory
                {
                    Id = Guid.Parse("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"),
                    CategoryName = "Computers"
                });
        }
    }
}