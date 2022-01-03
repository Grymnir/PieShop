using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext AppDbContext;
        public PieRepository(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return AppDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AppDbContext.Pies.Include(c => c.Category).Where(i => i.isPieOfTheWeek);
            }
        }

        public Pie getPieById(int pieID)
        {
            return AppDbContext.Pies.FirstOrDefault(fist => fist.pieID == pieID);
        }
    }
}
