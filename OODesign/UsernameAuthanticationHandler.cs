using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    internal class UsernameAuthanticationHandler : AuthanticationHandler
    {
        public override bool Authenticate(string username, string password)
        {
            Console.WriteLine("Cheaking Username....");
            if (nexthandler != null)
                return nexthandler.Authenticate(username, password);
            
            return true;
        }
    }
}
