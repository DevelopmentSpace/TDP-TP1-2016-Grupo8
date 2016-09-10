using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Suma del 1 al 100");
                int suma;
                suma = 0;

                for (int i = 1; i < 100 + 1; i = i + 2)
                {
                    suma = suma + i;
                }

                Console.WriteLine("Suma de los numero: ");
                Console.WriteLine(suma);
                Console.WriteLine("Promedio de los numeros: ");
                Console.WriteLine((float)suma / (((float)100) + 1));
                Console.ReadKey();

        }
    }
}
