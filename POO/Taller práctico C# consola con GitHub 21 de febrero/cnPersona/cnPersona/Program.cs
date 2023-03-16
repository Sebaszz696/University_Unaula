using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnPersona
{/// <summary>
/// SEBASTIAN VELASQUEZ PEREA 
/// 21/02/2023
/// Te preguntamos si eres mayor de edad
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine(nombre+" eres mayor de edad?");
            Console.WriteLine("Escribe 1 si eres mayor de edad");
            Console.WriteLine("Escribe 2 si eres menor de edad");
            string mayoriaDeEdad = Console.ReadLine();

            if (mayoriaDeEdad == "1")
            {

                MayorEdad();

            }
            else if (mayoriaDeEdad == "2")
            {

                MenorEdad();
            }
        }
        private static void MayorEdad()
        {

            Console.WriteLine("Eres mayor de edad");

            Console.WriteLine("Cual es tu apellido?");
            Console.ReadLine();
            Console.WriteLine("Cual es tu edad?");
            Console.ReadLine();
            Console.WriteLine("Escribe tu correo electronico");
            Console.ReadLine();
            Console.WriteLine("Muchas gracias por tu colaboracion");
        }
        private static void MenorEdad()
        {
            Console.WriteLine("Eres menor de edad");
        }

    }
}
