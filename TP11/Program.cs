using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio;
            float.TryParse(Console.ReadLine(),out radio) ;

            Console.WriteLine(2*radio*Math.PI);
            Console.WriteLine(Math.Pow(radio,2) *Math.PI);
            Console.ReadKey();
        }
    }
}
