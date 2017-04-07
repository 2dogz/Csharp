using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 101; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("Go");
                }

                else if (i % 7 == 0)
                {
                    Console.WriteLine("Cards!");
                }
              
                else if (i % 4 == 0 & i % 7 == 0)
                {
                    Console.WriteLine("Go Cards!");
                }
                else
                {
                    Console.WriteLine(i);

                    Console.ReadLine();
                }

            }

        }
    }
}
