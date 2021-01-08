using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShop.Services;

namespace CarShop.Models
{    
    public class User
    {
        private string _username;
        private string _password;

        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }
        public string UserName
        {
            get { return _username; }
            private set { _username = value; }
        }        
        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }     

    }
}
