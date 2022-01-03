using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pie { get; set; }
        public string CurrentCategory { get; set; }
    }
}
