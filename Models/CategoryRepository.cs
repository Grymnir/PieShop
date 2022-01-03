using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class CategoryRepository : IcategoryRepository
    {
        private readonly AppDbContext appDbContext;
        public CategoryRepository(AppDbContext AppDbContext)
        {
            appDbContext = AppDbContext;
        }

        public IEnumerable<Category> AllCategories => appDbContext.Categories;
    }
}
