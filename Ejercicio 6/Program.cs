using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que permita ingresar dos números e informar las relaciones
existentes entre ambos (mayor, menor, igual)*/

            int numero1, numero2;
            Console.WriteLine("digite el primer numero porfavor");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el Segundo numero porfavor");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El primer numero es mayor que el segundo");
            }
            if (numero1 < numero2)
            {
                Console.WriteLine("El Numero 2 es mayor que el Numero 1");
            }

            if (numero2 == numero1)
            {
                Console.WriteLine("los dos numeros son iguales");
            }

            Console.ReadKey();
        }
    }
}
