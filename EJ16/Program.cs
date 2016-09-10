using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ16
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeraP;
            string segundaP;
            int num1;
            int num2;
            primeraP = "";
            segundaP = "";

            int[] letras1 = new int[27] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] letras2 = new int[27] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Console.WriteLine("Ingrese la primera palabra");
            primeraP = Console.ReadLine();
            num1 = primeraP.Length;

            Console.WriteLine("Ingrese la segunda palabra");
            segundaP = Console.ReadLine();
            num2 = primeraP.Length;

            if (num1 == num2)
            {
                for (int i = 0; i < num1; i++)
                {
                    char letra;
                    letra = primeraP.First();
                    primeraP = primeraP.Remove(0, 1);

                    switch (letra)
                    {
                        case 'a':
                            letras1.SetValue((letras1[0]) + 1, 0);
                            break;
                        case 'b':
                            letras1.SetValue((letras1[1]) + 1, 1);
                            break;
                        case 'c':
                            letras1.SetValue((letras1[2]) + 1, 2);
                            break;
                        case 'd':
                            letras1.SetValue((letras1[3]) + 1, 3);
                            break;
                        case 'e':
                            letras1.SetValue((letras1[4]) + 1, 4);
                            break;
                        case 'f':
                            letras1.SetValue((letras1[5]) + 1, 5);
                            break;
                        case 'g':
                            letras1.SetValue((letras1[6]) + 1, 6);
                            break;
                        case 'h':
                            letras1.SetValue((letras1[7]) + 1, 7);
                            break;
                        case 'i':
                            letras1.SetValue((letras1[8]) + 1, 8);
                            break;
                        case 'j':
                            letras1.SetValue((letras1[9]) + 1, 9);
                            break;
                        case 'k':
                            letras1.SetValue((letras1[10]) + 1, 10);
                            break;
                        case 'l':
                            letras1.SetValue((letras1[11]) + 1, 11);
                            break;
                        case 'm':
                            letras1.SetValue((letras1[12]) + 1, 12);
                            break;
                        case 'n':
                            letras1.SetValue((letras1[13]) + 1, 13);
                            break;
                        case 'ñ':
                            letras1.SetValue((letras1[14]) + 1, 14);
                            break;
                        case 'o':
                            letras1.SetValue((letras1[15]) + 1, 15);
                            break;
                        case 'p':
                            letras1.SetValue((letras1[16]) + 1, 16);
                            break;
                        case 'q':
                            letras1.SetValue((letras1[17]) + 1, 17);
                            break;
                        case 'r':
                            letras1.SetValue((letras1[18]) + 1, 18);
                            break;
                        case 's':
                            letras1.SetValue((letras1[19]) + 1, 19);
                            break;
                        case 't':
                            letras1.SetValue((letras1[20]) + 1, 20);
                            break;
                        case 'u':
                            letras1.SetValue((letras1[21]) + 1, 21);
                            break;
                        case 'v':
                            letras1.SetValue((letras1[22]) + 1, 22);
                            break;
                        case 'w':
                            letras1.SetValue((letras1[23]) + 1, 23);
                            break;
                        case 'x':
                            letras1.SetValue((letras1[24]) + 1, 24);
                            break;
                        case 'y':
                            letras1.SetValue((letras1[25]) + 1, 25);
                            break;
                        case 'z':
                            letras1.SetValue((letras1[26]) + 1, 26);
                            break;
                    }
                }

                for (int i = 0; i < num2; i++)
                {
                    char letra;
                    letra = segundaP.First();
                    segundaP = segundaP.Remove(0, 1);

                    switch (letra)
                    {
                        case 'a':
                            letras2.SetValue((letras2[0]) + 1, 0);
                            break;
                        case 'b':
                            letras2.SetValue((letras2[1]) + 1, 1);
                            break;
                        case 'c':
                            letras2.SetValue((letras2[2]) + 1, 2);
                            break;
                        case 'd':
                            letras2.SetValue((letras2[3]) + 1, 3);
                            break;
                        case 'e':
                            letras2.SetValue((letras2[4]) + 1, 4);
                            break;
                        case 'f':
                            letras2.SetValue((letras2[5]) + 1, 5);
                            break;
                        case 'g':
                            letras2.SetValue((letras2[6]) + 1, 6);
                            break;
                        case 'h':
                            letras2.SetValue((letras2[7]) + 1, 7);
                            break;
                        case 'i':
                            letras2.SetValue((letras2[8]) + 1, 8);
                            break;
                        case 'j':
                            letras2.SetValue((letras2[9]) + 1, 9);
                            break;
                        case 'k':
                            letras2.SetValue((letras2[10]) + 1, 10);
                            break;
                        case 'l':
                            letras2.SetValue((letras2[11]) + 1, 11);
                            break;
                        case 'm':
                            letras2.SetValue((letras2[12]) + 1, 12);
                            break;
                        case 'n':
                            letras2.SetValue((letras2[13]) + 1, 13);
                            break;
                        case 'ñ':
                            letras2.SetValue((letras2[14]) + 1, 14);
                            break;
                        case 'o':
                            letras2.SetValue((letras2[15]) + 1, 15);
                            break;
                        case 'p':
                            letras2.SetValue((letras2[16]) + 1, 16);
                            break;
                        case 'q':
                            letras2.SetValue((letras2[17]) + 1, 17);
                            break;
                        case 'r':
                            letras2.SetValue((letras2[18]) + 1, 18);
                            break;
                        case 's':
                            letras2.SetValue((letras2[19]) + 1, 19);
                            break;
                        case 't':
                            letras2.SetValue((letras2[20]) + 1, 20);
                            break;
                        case 'u':
                            letras2.SetValue((letras2[21]) + 1, 21);
                            break;
                        case 'v':
                            letras2.SetValue((letras2[22]) + 1, 22);
                            break;
                        case 'w':
                            letras2.SetValue((letras2[23]) + 1, 23);
                            break;
                        case 'x':
                            letras2.SetValue((letras2[24]) + 1, 24);
                            break;
                        case 'y':
                            letras2.SetValue((letras2[25]) + 1, 25);
                            break;
                        case 'z':
                            letras2.SetValue((letras2[26]) + 1, 26);
                            break;
                    }
                }

                bool esIgual = Enumerable.SequenceEqual(letras1,letras2);

                if (esIgual)
                {
                    Console.WriteLine("Es un anagrama");
                }
                else
                {
                    Console.WriteLine("No es un anagrama");
                }

            }
            else
            {
                Console.WriteLine("No es un anagrama");
            }

            Console.ReadKey();

        }
    }
}
