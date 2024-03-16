using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    public class SortCommand
    {
        private ISorting Strategy;

        public SortCommand (ISorting strategy)
        {
            Strategy = strategy;
        }

        public void Execute(int[] arr)
        {
            Strategy.Sort(arr);
        }
    }
}
