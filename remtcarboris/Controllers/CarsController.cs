using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remtcarboris.Controllers
{
    public class CarsController
    {
        private readonly AppDbContext _context;

        public CarsController(AppDbContext context)
        {
            _context = context;
        }
    }
}