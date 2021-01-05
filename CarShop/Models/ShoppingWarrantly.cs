using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class ShoppingWarrantly
    {
        public List<Warranty> Warrantly { get; set; } = new List<Warranty>();

        public decimal SumOfAllWarrantly { get => Warrantly.Sum(p => p.Sum); }
    }
}
