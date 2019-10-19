using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;

namespace Pms.Api.Controllers
{
    public class ODataBaseController<TEntity> : ODataController
        where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repository;
        public ODataBaseController(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        [ODataRoute]
        [EnableQuery(PageSize = 2)]
        public IActionResult Get()
        {
            return Ok(_repository.Query());
        }

        [ODataRoute("({id})")]
        [EnableQuery]
        public virtual SingleResult<TEntity> Get([FromODataUri] Guid id)
        {
            var entity = _repository.Query().Where(q => q.Id.Equals(id));
            return SingleResult.Create(entity);
        }

        [ODataRoute()]
        public virtual async Task<IActionResult> Post([FromBody] TEntity entity)
        {
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
            return Ok();
        }

        [ODataRoute]
        [HttpPut]
        public virtual async Task<IActionResult> Put([FromBody] TEntity entity)
        {
            if (await _repository.IsExistAsync(entity.Id) == false)
            {
                return NotFound();
            }

            _repository.Update(entity);
            await _repository.SaveChangesAsync();
            return Ok();
        }

        [ODataRoute("{id}")]
        [HttpDelete()]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            if (await _repository.IsExistAsync(id) == false)
            {
                return NotFound();
            }

            _repository.Delete(id);
            await _repository.SaveChangesAsync();
            return Ok();
        }
    }
}