using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODesign
{
    internal class SortingManu
    {
        public void Manu() 
        {
            Console.WriteLine("Indicete size of your list ");
            int size = ConsolInput.Example.ReadInt();
            int[] arr = new int[size];

            Console.WriteLine("Indicete list of numbers to add");

            for (int i = 0; i < size; i++)
            {
                Random random = new Random();
                arr[i] = ConsolInput.Example.ReadInt();
            }
            Console.WriteLine("choos sorting algorithm betwee (bubble / quick) sort ");

            string strateginame = ConsolInput.Example.ReadLine();
            IUserObserver observer = new UserObserver();
            observer.SelectedSortStrategy(strateginame);

            ISorting strategy = SortingLogikFactory.GetSortingStrategi(strateginame);
            SortCommand sortcommand = new SortCommand(strategy);
            sortcommand.Execute(arr);
            foreach (int number in arr)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine("sorted list of numbers finish: ");
        }
    }
}
