using Microsoft.AspNet.OData.Routing;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;

namespace Pms.Api.Controllers.OData
{
    [ODataRoutePrefix("products")]
    public class ProductODataController : ODataBaseController<Product>
    {
        public ProductODataController(IRepository<Product> productRepository)
            : base(productRepository)
        {
        }
    }
}