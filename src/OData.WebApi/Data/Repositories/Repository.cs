using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OData.WebApi.Data.Entities;

namespace OData.WebApi.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        private ProductDbContext _context;
        private DbSet<TEntity> _dbSet;
        public Repository(ProductDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public Task<List<TEntity>> GetListAsync()
        {
            return _dbSet.ToListAsync();
        }
        public Task<TEntity> GetByIdAsync(object id)
        {
            return _dbSet.FindAsync(id);
        }

        public async Task<bool> IsExistAsync(Guid id)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(q => q.Id == id) != null;
        }
        public void Add(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.CreatedBy = "admin";
            _dbSet.Add(entity);
        }
        public void Update(TEntity entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedBy = "admin";
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            TEntity existing = _dbSet.Find(id);
            _dbSet.Remove(existing);
        }
        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public IQueryable<TEntity> Query()
        {
            return _dbSet;
        }
    }
}