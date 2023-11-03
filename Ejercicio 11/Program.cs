using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*.Desarrollar un algoritmo que permita al usuario ingresar las edades de 8 personas, al 
finalizar los ingresos informar el porcentaje de personas mayores y menores de edad, 
Se considera mayor de edad a la persona que tiene 18 años o más*/

            int edad, porcentajeMayores = 0, porcentajeMenores = 0, cont = 0;

            for (int i = 1; i <= 8; i++)
            {

                Console.WriteLine("Digite La edad de la persona" + i);
                edad = int.Parse(Console.ReadLine());


                if (edad >= 18)
                {

                    cont++;

                }



            }


            porcentajeMayores = (100 * cont) / 8;
            porcentajeMenores = 100 - porcentajeMayores;

            Console.WriteLine("Hay" + porcentajeMayores + " % de Mayores");
            Console.WriteLine("Hay" + porcentajeMenores + " % de Menores");

            Console.ReadKey();



        }
    }
}
