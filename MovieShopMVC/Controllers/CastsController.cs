using System;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class CastsController : Controller
    {
        private readonly ICastService _castService;

        public CastsController(ICastService castService)
        { 
            _castService = castService;
        }
        public async Task<IActionResult> Details(int id)
        {
           
            var cast = await _castService.GetCastDetails(id);
            return View(cast);
        }
    }
}
