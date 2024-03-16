using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    public class SortingLogikFactory
    {
       public static ISorting GetSortingStrategi(string strategyname)
        {
            switch (strategyname.ToLower())
            {
                case "quick":
                    return new QuickSort();
                case "bubble":
                    return new BubbleSort();
                default:
                    throw new ArgumentException("you have to use only quick or buble sorting algoritm");
            }
        }
    }
}
