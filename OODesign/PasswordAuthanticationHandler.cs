using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    internal class PasswordAuthanticationHandler : AuthanticationHandler
    {
        public override bool Authenticate(string username, string password)
        {
            Console.WriteLine("Checking password...");
           
            return true;
        }
    }
}
