using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CnTallerPractico
{
    internal class ClsSeptimoPunto
    {
        public static void MayorMenor()
        {
            Console.WriteLine("Escribe el primer valor");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el tercer valor");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            ValorMayor(valor1, valor2, valor3);
            Menor(valor1, valor2, valor3);
        }
        public static void ValorMayor(double valor1, double valor2, double valor3)
        {
            if (valor1 > valor2 & valor1 > valor3)
            {
                Console.WriteLine("El primer valor es el mayor = " + valor1);
            }
            else if (valor2 > valor1 & valor2 > valor3)
            {
                Console.WriteLine("El segundo valor es el mayor = " + valor2);
            }
            else if (valor3 > valor1 & valor3 > valor2)
            {
                Console.WriteLine("El tercer valor es el mayor = " + valor3);
            }
          
            Console.ReadKey();

        }
        public static void Menor(double valor1, double valor2, double valor3)
        {
            if (valor1 < valor2 & valor1 < valor3)
            {
                Console.WriteLine("El primer valor es el menor = " + valor1);
            }
            else if (valor2 < valor1 & valor2 < valor3)
            {
                Console.WriteLine("El segundo valor es el menor = " + valor2);
            }
            else if (valor3 < valor1 & valor3 < valor2)
            {
                Console.WriteLine("El tercer valor es el menor = " + valor3);
            }

            Console.ReadKey();

        }

    }
}
