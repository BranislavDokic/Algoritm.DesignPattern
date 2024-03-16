using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OODesign
{
    public class ConsolInput
    {
        private static ConsolInput example;
        private bool correct = false;
        
        public static ConsolInput Example
        {
            get 
            {
                if (example == null)
                {
                    example = new ConsolInput();
                }
                return example;
            }
        }
        private ConsolInput() { }

        public string ReadLine()
        {
            string input;
            bool result = false;
            while (!result)
            {
                input = Console.ReadLine();
                if (input != "quick" && input != "bubble")
                {
                    Console.WriteLine("Write only quick or bubble");
                   
                }
                else
                {
                    result = true;
                    return input;
                }
            }
            return "";
        }

        public int ReadInt()
        {
            int result;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("type in only numbers: ");
                }
            }

        }

    }
}
