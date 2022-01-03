using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly IcategoryRepository _categoryRepository;

        public PieController(IPieRepository pie, IcategoryRepository category)
        {
            _pieRepository = pie;
            _categoryRepository = category;
        }

        public ViewResult list(string category)
        {
            IEnumerable<Pie> allPiesInList;
            string currentCategory;
            if(string.IsNullOrEmpty(category))
            {
                allPiesInList = _pieRepository.AllPies.OrderBy(a => a.pieID);
                currentCategory = "All Pies";
            }
            else
            {
                allPiesInList = _pieRepository.AllPies.Where(pies => pies.Category.CategoryName == category)
                    .OrderBy(a => a.pieID);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(first => first.CategoryName == category)?.CategoryName;
            }
            return View(new PieListViewModel
            {
                Pie = allPiesInList,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.getPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}
