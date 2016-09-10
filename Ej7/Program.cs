using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese la cantidad de terminos de la formula:");
            int.TryParse(Console.ReadLine(), out n);

            double lebniz;
            lebniz = 0;

            for (int i = 0; i < n; i++)
            {
                lebniz = lebniz + ((Math.Pow(-1,i) / ((2 * i) + 1)) );
            }
            Console.WriteLine("Formula de Lebniz:");
            Console.WriteLine(lebniz);
            Console.WriteLine("Lebniz multiplicado por 4:");
            Console.WriteLine(lebniz*4);
            Console.WriteLine("Error de la formula de Lebniz en %");
            Console.WriteLine(100 - ((lebniz * 4 / Math.PI) * 100));

            Console.ReadKey();
        }
    }
}
