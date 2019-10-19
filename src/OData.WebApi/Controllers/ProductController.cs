using Microsoft.AspNetCore.Mvc;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;

namespace Pms.Api.Controllers.OData
{
    [Route("api/products")]
    public class ProductController : BaseController<Product>
    {
        public ProductController(IRepository<Product> productRepository)
            : base(productRepository)
        {
        }
    }
}