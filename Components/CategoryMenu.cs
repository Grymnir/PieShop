using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly IcategoryRepository _categoryRepository;

        public CategoryMenu(IcategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(pie => pie.CategoryName);
            return View(categories);
        }
    }
}
