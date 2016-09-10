using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int liminf;
            int limsup;

            Console.WriteLine("Ingrese el limite inferior");
            int.TryParse(Console.ReadLine(), out liminf);

            Console.WriteLine("Ingrese el limite superior");
            int.TryParse(Console.ReadLine(), out limsup);

            if (liminf <= limsup)
            {
                int suma;
                suma = 0;

                int i;
                i = liminf;

                do
                {
                    suma = suma + i;
                    i++;
                }
                while (i <= limsup);

                Console.WriteLine("Suma de los numero: ");
                Console.WriteLine(suma);
                Console.WriteLine("Promedio de los numeros: ");
                Console.WriteLine((float)suma / (((float)limsup - (float)liminf) + 1));
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Valores ingresados invalidos");
            }
        }
    }
}