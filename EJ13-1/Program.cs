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

            int num1 = args.Length;

            for (int j = 0; j < num1; j++)
            {

                Console.Write("Linea " + j + ":  " + args[j] + " - " );
                string cadenaMod;
                char letra;
                int num;

                cadenaMod = "";
                num = args[j].Length;

                for (int i = 0; i < num; i++)
                {
                    letra = args[j].Last();
                    args[j] = args[j].Remove((args[j].Length) - 1, 1);

                    cadenaMod = cadenaMod + letra.ToString();
                }

                Console.WriteLine("Cadena Modificada: " + cadenaMod);

                args.SetValue(cadenaMod, j);
            }

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Array sin ordenar:");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args.GetValue(i));
            }

            // hacer con for, 

            bool hubo_cambio;
            string temp;
            int k = 0;
            int pos = args.Length - 1;
            do
            {
                hubo_cambio = false;
                for (int i = 0; i < pos; i++)
                    if (string.Compare(args[i], args[i + 1]) == -1)
                    {
                        temp = args[i];
                        args[i] = args[i + 1];
                        args[i + 1] = temp;
                        hubo_cambio = true;
                        k = i;
                    }
                pos = k;
            }
            while (hubo_cambio);


            Console.WriteLine("Array ordenado:");
            for (int i = args.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(args.GetValue(i));
            }

            Console.ReadKey();
        }
    }
}

