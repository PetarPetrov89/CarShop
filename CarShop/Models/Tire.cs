using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Tire
    {
        //Default Constuctor
        public Tire()
        {
            winterTiresMercedes = 0.0;
            summerTiresMercedes = 0.0;
            winterTiresBMW = 0.0;
            summerTiresBMW = 0.0;
            winterTiresToyota = 0.0;
            summerTiresToyota = 0.0;
            winterTiresDacia = 0.0;
            summerTiresDacia = 0.0;            
        }
        public Tire(double wintertiresMercedes, double summertiresMercedes, double wintertiresBMW, double summertiresBMW, double wintertiresToyota, double summertiresToyota,
            double wintertiresDacia, double summertiresDacia)
        {
            //Tires
            winterTiresMercedes = wintertiresMercedes;
            summerTiresMercedes = summertiresMercedes;
            winterTiresBMW = wintertiresBMW;
            summerTiresBMW = summertiresBMW;
            winterTiresToyota = wintertiresToyota;
            summerTiresToyota = summertiresToyota;
            winterTiresDacia = wintertiresDacia;
            summerTiresDacia = summertiresDacia;
        }
        private double winterTiresMercedes;
        private double summerTiresMercedes;
        private double winterTiresBMW;
        private double summerTiresBMW;
        private double winterTiresToyota;
        private double summerTiresToyota;
        private double winterTiresDacia;
        private double summerTiresDacia;

        
    }
}
