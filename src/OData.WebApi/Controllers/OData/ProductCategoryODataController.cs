using Microsoft.AspNet.OData.Routing;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;

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