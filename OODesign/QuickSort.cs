using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    public class QuickSort : ISorting
    {
        

        public void Sort(int[] arr)
        {
            GetQuicksort(arr, 0, arr.Length - 1);
            Console.WriteLine("using quicksort");

        }

        private void GetQuicksort(int[] arr, int low, int hight)
        {
            if (low < hight)
            {
                int pivotindex = QuickSortLogik(arr, low, hight);
                GetQuicksort(arr, low, pivotindex - 1);
                GetQuicksort(arr, pivotindex + 1, hight);
            }
        }

        private int QuickSortLogik(int[] arr, int low, int hight)
        {
            int pivot = arr[hight];
            int i = low - 1;
            for (int j = low; j < hight; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);

                }
            }
            Swap(arr, i + 1, hight);
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
