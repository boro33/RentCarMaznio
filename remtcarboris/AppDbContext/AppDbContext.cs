using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remtcarboris.NewFolder
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}

