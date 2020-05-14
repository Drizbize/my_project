using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            if (number > 1)
            {
                while (i != number)
                {
                    Console.WriteLine(i++);
                }
                Console.WriteLine(i++);
                Console.WriteLine("Done");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
        }
    }
}
