using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OData.WebApi.Data.Entities;

namespace OData.WebApi.Data.TypeConfigurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                //Computer Products
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"),
                    ProductName = "HP Zbook",
                    Description = "HP Zbook Laptop",
                    Weight = 3,
                    Price = 2000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"),
                    ProductName = "MacBook Pro",
                    Description = "MacBook Laptop",
                    Weight = 2.1,
                    Price = 3000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"),
                    ProductName = "Lenovo Thinkpad",
                    Description = "Lenovo Thinkpad Laptop",
                    Weight = 1.7,
                    Price = 2800
                },

                //TV Products
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("8b726886-e719-413c-a125-939ee5af387d"),
                    ProductName = "LG 32-Inch",
                    Description = "LG 32-Inch 720p LED TV",
                    Weight = 60,
                    Price = 12000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("8b726886-e719-413c-a125-939ee5af387d"),
                    ProductName = "Sony 65-Inch",
                    Description = "Sony 65-Inch 4K Ultra HD Smart LED TV",
                    Weight = 70,
                    Price = 10000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("8b726886-e719-413c-a125-939ee5af387d"),
                    ProductName = "Samsung 32-Inch",
                    Description = "Samsung 32-Inch 1080p Smart LED TV",
                    Weight = 50,
                    Price = 15000
                },

                //Headphone Products
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("1236a458-0802-4340-bdd4-05859c9aaaad"),
                    ProductName = "JBL Tune",
                    Description = "JBL Tune 500BT On-Ear",
                    Weight = 0.3,
                    Price = 15
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("1236a458-0802-4340-bdd4-05859c9aaaad"),
                    ProductName = "Panasonic ErgoFit",
                    Description = "Panasonic ErgoFit In-Ear",
                    Weight = 0.4,
                    Price = 29
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryId = Guid.Parse("1236a458-0802-4340-bdd4-05859c9aaaad"),
                    ProductName = "Sennheiser CX",
                    Description = "Sennheiser CX Wireless In-Ear",
                    Weight = 0.4,
                    Price = 44
                });
        }
    }
}