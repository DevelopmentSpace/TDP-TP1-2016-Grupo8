using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args) //Punto de entrada de la ejecucion de una aplicacion. No se puede instanciar program.
        {                               //Firma de un objeto: el nombre y el conjunto de parametros. Solo una clase principal por proyecto.
            int num;
            Console.WriteLine("Ingrese un numero");
            int.TryParse(Console.ReadLine(), out num);

            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("UNO");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("DOS");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("TRES");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("CUATRO");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("CINCO");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("SEIS");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("SIETE");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("OCHO");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("NUEVE");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("OTRO");
                        break;
                    }

            }
            Console.ReadKey();

        }
    }
}
