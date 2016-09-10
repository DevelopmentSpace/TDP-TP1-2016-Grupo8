using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ANO1 = 1900;
            const int ANO2 = 2015;

            for (int i = ANO1; i < ANO2; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
