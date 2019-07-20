using System;

namespace OData.WebApi.Data.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public Guid CategoryId { get; set; }
        public ProductCategory Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
    }
}