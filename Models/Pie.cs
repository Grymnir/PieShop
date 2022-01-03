using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Pie
    {
        public int pieID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string imageURL { get; set; }
        public string imageThumbnailURL { get; set; }
        public bool isPieOfTheWeek { get; set; }
        public bool inStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
