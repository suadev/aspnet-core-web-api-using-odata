using System;
using OData.WebApi.Data.Entities;

namespace OData.WebApi.Dto
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
    }
}