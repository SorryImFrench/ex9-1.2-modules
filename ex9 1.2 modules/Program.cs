using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9_1._2_modules
{
    class Program // trouver une valeur absolue
    {
        const int zero = 0; // Constante pour éviter valeurs dures
        static int abs(int n) // fonction du cours à mod en procedure après
        {

            if (n < zero)
            {
                return -n;
            }
            else
            {
                return n;
            }
        }
        static void Main(string[] args)
        {
            int val = zero;
            bool valide = false;
            do
            {
                try
                {
                    Console.Write("Entrer un chiffre = ");
                    val = int.Parse(Console.ReadLine());
                    valide = true;
                    Console.WriteLine("");
                }
                catch
                {
                    Console.WriteLine("^ Erreur, entrer un entier ^");
                }
            } while (!valide);
            Console.Write("La valeur absolue de " + val + " = " + abs(val));
            Console.Read();
        }
    }
}
