using System;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}