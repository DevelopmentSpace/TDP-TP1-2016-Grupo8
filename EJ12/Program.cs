using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial;
            double suma = 1; 
            int.TryParse(Console.ReadLine(),out factorial);

            for (int i = 1; i <= factorial; i++)
            {
                suma = (i * suma);
            }
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
