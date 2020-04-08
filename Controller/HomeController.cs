using System;
using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers
{
    [Route("api/movies")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
