using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockCategoryRepository : IcategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CateGoryID=1, CategoryName="Fruit Pies", Description="All-fruity pies"},
                new Category{CateGoryID=2, CategoryName="Cheese cakes", Description="Cheese all the way"},
                new Category{CateGoryID=3, CategoryName="Seasonal PIes", Description="Get in the mood for our seasonal pies"}
            };
    }
}
