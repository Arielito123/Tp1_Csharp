using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*. Sabiendo que el precio unitario de un artículo es de $35,00 desarrollar un algoritmo que
permita informar el importe al ingresar la cantidad, si dicha cantidad es mayor que 10 se
aplica un descuento del 10%.*/

            int cantidad; ;
            double importe = 0;
            float descuento = 0;
            Console.WriteLine("Digite La cantidad del producto que desea adquirir");
            cantidad = int.Parse(Console.ReadLine());

            importe = (cantidad * 35.00);
            Console.WriteLine("su Importe es de" + importe + "pesos");

            if (cantidad >= 10)
            {
                descuento = (float)(importe / 10);
                Console.WriteLine("Su Descuento es de: " + descuento + "pesos");
            }

            else
            {
                Console.WriteLine("no tienes descuento");
            }
            Console.ReadKey();
        }
    }
}
