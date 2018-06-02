using System.Threading.Tasks;
using SQLite;
using TekVan.Model;
using TekVan.Service;

namespace TekVan.Repository
{
    public class UserRepository :Repository<User>,IUserRepository
    {
        public UserRepository(SQLiteAsyncConnection connection) : base(connection)
        {
            CreateTableAsync(connection);
        }

        private async void CreateTableAsync(SQLiteAsyncConnection conn)
        {
            await conn.CreateTableAsync<User>();
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await Find(p => p.Id == username && p.Password == password);
            return user != null;
        }

        public async Task<bool> ValidationAsync(string username)
        {
            var valid = await Find(p => p.Id == username);
            if (valid == null)
            {
                return true;
            }

            return false;
        }
    }
}