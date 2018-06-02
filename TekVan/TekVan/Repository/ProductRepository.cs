using SQLite;
using TekVan.Model;
using TekVan.Service;

namespace TekVan.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SQLiteAsyncConnection connection) : base(connection)
        {
            CreateTableAsync(connection);
        }

        private async void CreateTableAsync(SQLiteAsyncConnection conn)
        {
            await conn.CreateTableAsync<User>();
        }
    }
}