using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Client
    {
        private int _id;
        private string _name;
        private long _bulstat;

        public long Bulstat
        {
            get { return _bulstat; }
            set { _bulstat = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
