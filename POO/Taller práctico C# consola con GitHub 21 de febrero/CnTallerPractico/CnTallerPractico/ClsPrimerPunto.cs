using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTallerPractico
{
    internal class ClsPrimerPunto
        
    {
        public static void MayoriaEdad()
        {

            Console.WriteLine("Cual es tu nombre");
            string nombre = Console.ReadLine(); 

            Console.WriteLine(nombre + " cual es tu edad");
            int edad = Convert.ToInt16(Console.ReadLine());

            if (edad>=18)
            {
                Console.WriteLine(nombre+" eres mayor de edad");

            }
            else 
            {
                Console.WriteLine(nombre+" eres menor de edad");
            }
            Console.ReadKey();
        }



    }
}
