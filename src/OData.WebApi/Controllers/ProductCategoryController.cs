using Microsoft.AspNetCore.Mvc;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;

namespace Pms.Api.Controllers.OData
{
    [Route("api/product_categories")]
    public class ProductCategoryController : BaseController<ProductCategory>
    {
        public ProductCategoryController(IRepository<ProductCategory> productRepository)
            : base(productRepository)
        {
        }
    }
}