using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }



        public User(UserBilder bilder)
        {
            UserName = bilder.UserName;
            Password = bilder.Password;
            Email = bilder.Email;
            Age = bilder.Age;
        }
    }
}
