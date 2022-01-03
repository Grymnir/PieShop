using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _PieRepository;
        public HomeController(IPieRepository pieRepository)
        {
            _PieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var home = new HomeViewModel
            {
                piesOfTheWeek = _PieRepository.PiesOfTheWeek
            };
            return View(home);
        }
    }
}
