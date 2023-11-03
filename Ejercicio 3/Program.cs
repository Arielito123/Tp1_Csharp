using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que permita a un usuario ingresar dos números, si el primero es
mayor al segundo informar el producto de ambos, sino informar la sumatoria*/

            int numero1, numero2, producto = 0, suma = 0;

            Console.WriteLine("Digite el primer numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                producto = numero1 * numero2;
                Console.WriteLine("EL primer numero al ser mayor que el segundo ambos se multiplicaran " + producto);
            }

            else
            {
                suma = numero1 + numero2;
                Console.WriteLine("Al ser menor el primer numero que el segundo se sumaran " + suma);

            }

            Console.ReadKey();

        }
    }
}
