using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTallerPractico
{
    internal class ClsSegundoPunto
    {

        public static void Triangulo()
        {
            Console.WriteLine("Primer lado");
            double lado1 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Segundo Lado");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tercer Lado ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            LadoMayor(lado1,lado2,lado3);
        }
        public static void LadoMayor(double lado1, double lado2,double lado3)
        {
            if (lado1>lado2 & lado1>lado3)
            {
                Console.WriteLine("El primer lado es el mayor = " + lado1);
            }
            else if (lado2 > lado1 & lado2 > lado3)
            {
                Console.WriteLine("El segundo lado es el mayor = " + lado2);
            }
            else if (lado3 > lado1 & lado3 > lado2)
            {
                Console.WriteLine("El tercer lado es el mayor = " + lado3);
            }
            else
            {
                Equilatero();

            }
            Console.ReadKey();
            
        }

        public static void Equilatero () 
        {
            Console.WriteLine("El triangulo es equilatero");
        }




    }
}
