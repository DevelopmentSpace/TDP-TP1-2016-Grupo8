using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[50];
            Random a = new Random();
            int b;
            const int num1 = 1000;
            const int num2 = 2000;

            for (int i = 0; i < numeros.Length; i++)
            {
                b = a.Next(num1,num2);
                numeros.SetValue(b, i);
            }
            Array.Sort(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(" - " + numeros.GetValue(i));
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

