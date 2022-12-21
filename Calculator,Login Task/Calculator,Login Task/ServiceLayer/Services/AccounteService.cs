using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccounteService : IAccounteService
    {
        public bool Login(string username, string password)
        {
            if (username == "Aqsin" && password == "1995a")
            {
                return true;
            }
            
            return false;
        }
    }
}
