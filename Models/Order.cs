using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonAutosport.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Buyer { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int AutoId { get; set; }
        public Auto auto { get; set; }
    }
}
