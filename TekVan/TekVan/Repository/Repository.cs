using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SQLite;
using TekVan.Service;

namespace TekVan.Repository
{
    public class Repository<TEntity> :IRepository<TEntity> where TEntity:class ,new ()
    {
        public readonly SQLiteAsyncConnection _connection;

        public Repository(SQLiteAsyncConnection connection)
        {
            _connection = connection;
        }

        public async Task<TEntity> Get(int id)
        {
            return await _connection.FindAsync<TEntity>(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _connection.Table<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await _connection.FindAsync(predicate);
        }

        public async Task<int> Add(TEntity entity)
        {
            return await _connection.InsertAsync(entity);
        }
    }
}