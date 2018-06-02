using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TekVan.Service
{
    public interface IRepository<TEntity> where TEntity: class,new()
    {
        Task<TEntity> Get(int id);
        Task<List<TEntity>> GetAll();
        Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        Task<int> Add(TEntity entity);
    }
}