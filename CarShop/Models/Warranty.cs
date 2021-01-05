using CarShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Warranty
    {
        private string _years;
        private decimal _price;
        private int _qty;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Years
        {
            get { return _years; }
            set { _years = value; }
        }        

        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
        public decimal Sum
        {
            get => Price * (decimal)Qty;
        }

        public static List<Warranty> GetWarantly()
            {
                return new List<Warranty>()
            {
                new Warranty()
                {
                    Years = "Two years",
                    Price = 500,
                    Qty = 0
                },
                new Warranty()
                {
                    Years = "Three years",
                    Price = 750,
                    Qty = 0
                },
                 new Warranty()
                {
                    Years = "Four years",
                    Price = 900,
                    Qty = 0
                },
                 new Warranty()
                {
                    Years = "Five years",
                    Price = 1100,
                    Qty = 0
                },
            };
            }               
    }
}
