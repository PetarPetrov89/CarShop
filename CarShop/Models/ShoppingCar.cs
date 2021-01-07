using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class ShoppingCar
    {
        public List<Car> Cars { get; set; } = new List<Car>();
               

        public decimal SumOfAllCars { get => Cars.Sum(p => p.Sum); }
    }
}
