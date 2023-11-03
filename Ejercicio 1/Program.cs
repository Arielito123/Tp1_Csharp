using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un algoritmo que permita ingresar un número e informe si el mismo 
             es mayor que 50.*/

            int numero;

            Console.WriteLine("Digite su numero");
            numero = int.Parse(Console.ReadLine());

            if (numero > 50)
            {
                Console.WriteLine("El numero elejido es mayor que 50");
            }
            else
            {

                Console.WriteLine("el Numero elejido es menor que 50");


            }
            Console.ReadLine();
        }
    }
}
