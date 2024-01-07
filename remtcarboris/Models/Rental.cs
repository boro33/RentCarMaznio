using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remtcarboris.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }
    }
}
