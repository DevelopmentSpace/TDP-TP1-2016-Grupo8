using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ13
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] palabras = new string[5] { "", "", "", "", "" };

            for (int j = 0; j < 5; j++)
            {

                Console.Write("Linea " + j + ":  ");
                string cadena = Console.ReadLine();
                string cadenaMod;
                char letra;
                int num;

                cadenaMod = "";
                num = cadena.Length;
                palabras.SetValue("",j);

                /*Console.WriteLine("Linea 2:");
                string cadena2 = Console.ReadLine();
                Console.WriteLine("Linea 3:");
                string cadena3 = Console.ReadLine();
                Console.WriteLine("Linea 4:");
                string cadena4 = Console.ReadLine();
                Console.WriteLine("Linea 5:");
                string cadena5 = Console.ReadLine();*/

                for (int i = 0; i < num; i++)
                {
                    letra = cadena.Last();
                    cadena = cadena.Remove((cadena.Length) - 1, 1);

                    cadenaMod = cadenaMod + letra.ToString();
                }

                Console.WriteLine("Cadena Modificada: " + cadenaMod);

                palabras.SetValue(cadenaMod, j);
            }
            Console.Clear();

            Console.WriteLine("Array sin ordenar:");
            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras.GetValue(i));
            }


            Array.Sort(palabras);
            Console.WriteLine("Array ordenado:");
            for (int i = palabras.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(palabras.GetValue(i));
            }

            Console.ReadKey();     
        }
    }
}
