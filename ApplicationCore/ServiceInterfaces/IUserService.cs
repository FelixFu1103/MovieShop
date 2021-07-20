using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel requestModel);

        Task<UserLoginResponseModel> Login(string email, string password);
        //Task<List<MovieCardResponseModel>> GetUserPurchasedMovies(int userId);
    }
}