using Microsoft.AspNet.OData.Routing;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;
using OData.WebApi.Dto;

namespace Pms.Api.Controllers.OData
{
    [ODataRoutePrefix("product_categories")]
    public class ProductCategoryODataController : ODataBaseController<ProductCategory>
    {
        public ProductCategoryODataController(IRepository<ProductCategory> productCategoryRepository)
            : base(productCategoryRepository)
        {
        }
    }
}