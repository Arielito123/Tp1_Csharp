using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Modificar el ejercicio anterior de manera que el algoritmo permita informar la cantidad 
de días en que la temperatura se mantuvo entre 21 grados y 24 grados inclusive*/

            int temp, cont = 0;

            for (int i = 1; i <= 7; i++)
            {

                Console.Write("Ingrese La Temperatura" + i + "\n");
                temp = int.Parse(Console.ReadLine());


                if ((temp >= 21) && (temp <= 24))
                {

                    cont++;

                }

            }

            Console.WriteLine("La cantidad de dias donde la temperatura se mantuvo entre 21 y 24 grado fue de:" + cont);

            Console.ReadKey();

        }
    }
}
