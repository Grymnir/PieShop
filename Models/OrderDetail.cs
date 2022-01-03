using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PieShop.Models
{
    public class OrderDetail
    {
        [Key]
        public int OderDetailID { get; set; }
        public int OrderID { get; set; }
        public int PieID { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Pie Pie { get; set; }
        public Order Order { get; set; }
    }
}
