using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Login_Task.Controllers
{
    internal class AccountController
    {

        public void Login()
        {
            IAccounteService accounteService = new AccounteService();

            Console.WriteLine( "Add username");
            string username = Console.ReadLine();

            Console.WriteLine("Add password");
            string password = Console.ReadLine();
            var result = accounteService.Login(username, password);


            if (result)
            {
                Console.WriteLine("Girish ugurludur");
            }
            else
            {
                Console.WriteLine("Ussername ve yaxud password yalnisdir");
            }


        }
       
    
    }
}
