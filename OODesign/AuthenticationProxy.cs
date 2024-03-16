using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
   public class AuthenticationProxy
   {
        public Dictionary<string, string> users;

        public AuthenticationProxy() 
        {
            users = new Dictionary<string, string>();
        }

        public void Register(string username, string password)
        {
            users[username] = password;
        }

        public bool LogIn(string username, string password) 
        {
            if(users.ContainsKey(username) && users[username] == password) 
            {
                Console.WriteLine("User " + username + " logged in successfully");
                
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password");
                return false;
            }
        }
   }
    
}
