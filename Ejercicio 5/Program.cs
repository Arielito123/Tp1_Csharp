using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se ingresa un número informar si el mismo es positivo, negativo o cero

            int numero;

            Console.WriteLine("Digite un numero");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Su Numero es positivo");
            }
            else
            {
                Console.WriteLine("SU numero es negativo");
            }
            Console.ReadKey(); ;
        }
    }
}
