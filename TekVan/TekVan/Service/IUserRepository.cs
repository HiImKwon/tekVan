using System.Threading.Tasks;
using TekVan.Model;

namespace TekVan.Service
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> LoginAsync(string username, string password);
        Task<bool> ValidationAsync(string username);
    }
}