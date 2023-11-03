using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresa un número, siendo el mismo 99 < N < 1000, se pide informar la suma de sus
            cifras*/

            int numero, suma = 0;

            Console.WriteLine("Digite Un numero de tres cifra");
            numero = int.Parse(Console.ReadLine());

            while (numero > 0)
            {

                suma = suma + numero % 10;
                numero = numero / 10;


            }

            Console.WriteLine("la suma de sus cifras son:" + suma);

            Console.ReadKey();


        }
    }
}
