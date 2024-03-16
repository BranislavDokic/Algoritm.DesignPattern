using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    public abstract class AuthanticationHandler 
    {
        protected AuthanticationHandler nexthandler;

        public void SetNextHandler(AuthanticationHandler handler)
        {
            nexthandler = handler;
        }

        public abstract bool Authenticate(string username, string password);
    }
}
