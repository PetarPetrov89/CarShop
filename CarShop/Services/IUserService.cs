﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Services
{
    public interface IUserService
    {
        bool TryLoginUser(string userame, string pasword); 
    }
}
