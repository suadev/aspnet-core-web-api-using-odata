using Microsoft.AspNetCore.Mvc;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;
using OData.WebApi.Dto;

namespace Pms.Api.Controllers.OData
{
    [Route("api/product_categories")]
    public class ProductCategoryController : BaseController<ProductCategory, ProductCategoryDto>
    {
        public ProductCategoryController(IRepository<ProductCategory> productRepository)
            : base(productRepository)
        {
        }
    }
}