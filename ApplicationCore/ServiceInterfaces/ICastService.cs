using System;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICastService
    {
        Task<CastDetailsResponseModel> GetCastDetails(int id);
    }
}
