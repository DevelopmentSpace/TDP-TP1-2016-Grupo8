using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args) //Punto de entrada de la ejecucion de una aplicacion. No se puede instanciar program.
        {                               //Firma de un objeto: el nombre y el conjunto de parametros. Solo una clase principal por proyecto.
            int num;
            Console.WriteLine("Ingrese un numero");
            int.TryParse(Console.ReadLine(),out num);

            if (num == 1)
            {
                Console.WriteLine("UNO");
            }
            else if (num == 2)
            {
                Console.WriteLine("DOS");
            }
            else if (num == 3)
            {
                Console.WriteLine("TRES");
            }
            else if (num == 4)
            {
                Console.WriteLine("CUATRO");
            }
            else if (num == 5)
            {
                Console.WriteLine("CINCO");
            }
            else if (num == 6)
            {
                Console.WriteLine("SEIS");
            }
            else if (num == 7)
            {
                Console.WriteLine("SIETE");
            }
            else if (num == 8)
            {
                Console.WriteLine("OCHO");
            }
            else if (num == 9)
            {
                Console.WriteLine("NUEVE");
            }
            else
            {
                Console.WriteLine("OTRO");
            }

            Console.ReadKey();

        }
    }
}
