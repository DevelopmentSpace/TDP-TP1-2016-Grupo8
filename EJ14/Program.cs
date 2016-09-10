using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ14
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[30];
            Random a = new Random();
            double b;

            for (int i = 0; i < numeros.Length; i++)
            {
                b = a.NextDouble() * 10;
                numeros.SetValue(b, i);
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(" - " + numeros.GetValue(i));
            }
            Console.WriteLine();
            Console.WriteLine("Minimo: " + numeros.Min());
            Console.WriteLine("Maximo: " + numeros.Max());
            Console.WriteLine("Suma: " + numeros.Sum());
            Console.WriteLine("Promedio: " + numeros.Average());

            Console.ReadKey();
        }
    }
}
