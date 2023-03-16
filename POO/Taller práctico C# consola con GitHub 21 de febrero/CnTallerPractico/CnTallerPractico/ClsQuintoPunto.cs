using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTallerPractico
{
    internal class ClsQuintoPunto
    {

        public static void Empleado() 
        {
            Console.WriteLine("Escribe tu nombre");
            string nombre =Console.ReadLine();
            Console.WriteLine("Cual es tu sueldo $");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            ImprimirDatos(nombre, sueldo);
            Impuestos(sueldo);
            Console.ReadKey();
        }
        public static void ImprimirDatos(string nombre, double sueldo)
        {
            Console.WriteLine("NOMBRE: "+ nombre);
            Console.WriteLine("SUELDO: "+ sueldo);
       
        }

        public static void Impuestos(double sueldo)
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe Pagar impuestos");
            }
            else
            {
                Console.WriteLine("Su sueldo es menor  o igual a 3000, no paga impuestos");
            }
        }
    }
}
