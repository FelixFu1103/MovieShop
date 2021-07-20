using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ICurrentUser _currentUser;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IUserService _userService;
        public UserController(ICurrentUser currentUser, IPurchaseRepository purchaseRepository, IUserService userService)
        {
            _currentUser = currentUser;
            _purchaseRepository = purchaseRepository;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ConfirmPurchase(int mId, decimal price)
        {
            if (!_currentUser.IsAuthenticated)
            {
                return LocalRedirect("~/Account/Login");
            }
            var entity = new Purchase
            {
                MovieId = mId,
                UserId = _currentUser.UserId,
                PurchaseDateTime = DateTime.Now,
                PurchaseNumber = Guid.NewGuid(),
                TotalPrice = price
            };

            await _purchaseRepository.AddAsync(entity);
            return LocalRedirect("~/Home/Index");
        }

        //public async Task<IActionResult> Purchased()
        //{
        //    var userId = _currentUser.UserId;
        //    var allMovies = await _userService.GetUserPurchasedMovies(userId);
        //    return View(allMovies);
        //}
    }
}