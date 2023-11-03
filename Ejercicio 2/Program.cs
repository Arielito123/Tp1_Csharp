using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se ingresa un número determinar e informar si el mismo es par o impar

            int numero;

            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Su Numero es par");
            }
            else
            {
                Console.WriteLine("Su Numero es Impar");
            }
            Console.ReadKey();
        }
    }
}
