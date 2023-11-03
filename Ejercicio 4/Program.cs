using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Se ingresan 5 letras informar la cantidad de vocales.

            char letra;
            int cont = 0;

            for (int i = 1; i < 6; i++)
            {

                Console.WriteLine("Ingrese 5 letras");
                letra = char.Parse(Console.ReadLine());

                if ((letra == 'a' || letra == 'e') || (letra == 'i' || letra == 'o') || letra == 'u')
                {
                    cont++;
                }
                else

                {
                    Console.WriteLine("No hay Vocales");
                }
            }

            Console.WriteLine("la cantidad de vocales que hay " + cont);
            Console.ReadKey();

        }
    }
}
