using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan las marcas diarias de temperatura de una semana, se pide informar la
            cantidad de días en que la temperatura fue mayor a 21 grados*/

            int temperatura, cont = 0;

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("\nIngrese las temperaturas que hubieron de lunes a domingo\n ");
                temperatura = int.Parse(Console.ReadLine());

                if (temperatura > 21)
                {
                    cont++;
                }
            }
            Console.WriteLine("\nla cantidad de dias donde la temperatura fue mayor a 21 son\n" + cont + "dias");
            Console.ReadKey();
        }
    }
}

