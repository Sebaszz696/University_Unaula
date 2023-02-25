using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTallerPractico
{
    internal class ClsCuartoPunto
    {
        public static void Cuadrado() 
        {
            Console.WriteLine("Escribe un lado del cuadrado");
            double lado = Convert.ToDouble(Console.ReadLine());

            MostrarPerimetro(lado);
            MostrarSuperficie(lado);

            Console.ReadKey();
        }

      
        public static void MostrarPerimetro(double lado) 
        {
            double perimetro = lado * 4;
            Console.WriteLine("El perimetro es: " + perimetro);
        }
        public static void MostrarSuperficie(double lado)
        {
            double superficie = lado * lado;
            Console.WriteLine("La superficie es: " + superficie);
        }
    }
}
