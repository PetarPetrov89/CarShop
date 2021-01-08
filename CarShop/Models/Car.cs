using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Models
{
    // Class Cars
    public class Car
    {
        private string _model;
        private decimal _price;
        private string _brand;
        private int _qty;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }     

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
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
        public static List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car()
                {
                    Brand = "Mercedes",
                    Model = "ML350",
                    Price = 12500,
                    Qty = 0
                },
                 new Car()
                {
                    Brand = "BMW",
                    Model = "X5",
                    Price = 10000,
                    Qty = 0
                },
                  new Car()
                {
                    Brand = "Toyota",
                    Model = "Rav 4",
                    Price = 8000,
                    Qty = 0
                },
                   new Car()
                {
                    Brand = "Dacia",
                    Model = "Duster",
                    Price = 5000,
                    Qty = 0
                }                  
            };
        }
    }
}
