using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Category
    {
        public int CateGoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Pie> pies { get; set; }
    }
}
