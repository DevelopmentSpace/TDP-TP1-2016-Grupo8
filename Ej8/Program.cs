using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            double fibonacci;

            double term1;
            double term2;

            fibonacci = 0;

            term2 = 1;
            term1 = 0;


            for (int i = 0; i < 51 - 1; i++)
            {
                fibonacci =  term2 + term1;

                term1 = term2;
                term2 = fibonacci;
            }

            Console.WriteLine("Fibonacci: ");
            Console.WriteLine(term1);
            Console.ReadKey();
        }
    }
}
