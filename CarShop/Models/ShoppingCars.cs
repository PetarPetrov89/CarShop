using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class ShoppingCars
    {
        public List<Cars> Cars { get; set; } = new List<Cars>();
               

        public decimal SumOfAllCars { get => Cars.Sum(p => p.Sum); }
    }
}
