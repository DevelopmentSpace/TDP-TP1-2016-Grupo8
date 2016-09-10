using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            long suma;
            suma = 0;
            for (int i = 35; i <= 1977; i++)
            {
                Boolean primo;
                primo = true;
                for (int k = 2; k < i - 1; k++)
                {
                    if (i % k == 0)
                    {
                        primo = false;
                    }
                }
                if (primo == true)
                {
                    suma = suma + i;
                }
            }

            Console.Write(suma);
            Console.ReadKey();
        }
    }
}
