using SQLite;
using TekVan.Service;

namespace TekVan.Repository
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly SQLiteAsyncConnection _connection;

        public UnitOfWork(SQLiteAsyncConnection connection)
        {
            _connection = connection;
            Users = new UserRepository(_connection);
            Products=new ProductRepository(_connection);
        }

        public IUserRepository Users { get; set; }
        public IProductRepository Products { get; set; }
    }
}