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

       

        public string SumOfAllCarsText
        { get => string.Format("{0:C}", Cars.Sum(p => p.Sum)); }

        public decimal SumOfAllCars { get => Cars.Sum(p => p.Sum); }
    }
}
