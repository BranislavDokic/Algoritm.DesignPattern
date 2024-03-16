using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    public class UserObserver : IUserObserver
    {
        public void SelectedSortStrategy(string strategy)
        {
            Console.WriteLine("User have choosed sortstrategy " +  strategy);
        }
    }
}
