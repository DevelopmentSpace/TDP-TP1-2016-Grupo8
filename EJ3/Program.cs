using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
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

                for (int i = liminf; i < limsup + 1 ; i++)
                {
                    suma = suma + i;
     
                }

                Console.WriteLine("Suma de los numero: ");
                Console.WriteLine(suma);
                Console.WriteLine("Promedio de los numeros: ");
                Console.WriteLine((float)suma /(((float)limsup-(float)liminf)+1));
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Valores ingresados invalidos");
            }
        }
    }
}
