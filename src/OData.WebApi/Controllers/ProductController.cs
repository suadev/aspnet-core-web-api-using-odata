using Microsoft.AspNetCore.Mvc;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;
using OData.WebApi.Dto;

namespace Pms.Api.Controllers.OData
{
    [Route("api/products")]
    public class ProductController : BaseController<Product, ProductDto>
    {
        public ProductController(IRepository<Product> productRepository)
            : base(productRepository)
        {
        }
    }
}