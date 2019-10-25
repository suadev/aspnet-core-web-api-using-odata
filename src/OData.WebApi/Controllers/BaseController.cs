using System;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.WebApi.Data.Entities;
using OData.WebApi.Data.Repositories;

namespace Pms.Api.Controllers
{
    [ApiController]
    public class BaseController<TEntity, TDto> : ControllerBase
        where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repository;
        public BaseController(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public IActionResult Get()
        {
            return Ok(_repository.Query().ProjectToType<TDto>());
        }

        [HttpGet("({id})")]
        public virtual SingleResult<TDto> Get([FromODataUri] Guid id)
        {
            var entity = _repository.Query().Where(q => q.Id.Equals(id)).ProjectToType<TDto>();
            return SingleResult.Create(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] TEntity entity)
        {
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
            return Ok();
        }

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

        [HttpDelete("{id}")]
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