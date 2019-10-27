using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OData.WebApi.Data.Entities;

namespace OData.WebApi.Data.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity
    {
        Task<bool> IsExistAsync(Guid id);
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(object id);
        Task<int> SaveChangesAsync();
        IQueryable<TEntity> Query();
    }
}