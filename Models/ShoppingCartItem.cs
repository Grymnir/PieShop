using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }
        public Pie pie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartID { get; set; }
    }
}
