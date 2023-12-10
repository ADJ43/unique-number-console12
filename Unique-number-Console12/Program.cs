using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_number_Console12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            
            bool run = true;

            while (run) 
            {
                Console.WriteLine("Please enter a number, or type 'Quit' to Exit");
                var input = Console.ReadLine();

                if (input == "Quit")
                {
                    run = false;
                    break;
                }
                else
                {
                    if (!numbers.Contains(int.Parse(input)))
                    {
                        numbers.Add(int.Parse(input));
                    }
                    
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
