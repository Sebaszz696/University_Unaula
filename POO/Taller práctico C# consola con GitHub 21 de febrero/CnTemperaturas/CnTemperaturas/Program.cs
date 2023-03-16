using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTemperatura
{
    internal class Program
    {
      
        /// <summary>
        /// 21/02/2023
        /// SEBASTIAN VELASQUEZ PEREA 
        /// Conversión de temperaturas de celsius a farenheit y viceversa
        /// </summary>
        /// <param name="args"></param>
       private static void Main(string[] args)
        {


            double total = 0;
            string tipo = "";

            Console.WriteLine("Escribe 1 para pasar de celsius a farenheit");
            Console.WriteLine("Escribe 2 para pasar de farenheit a celsius");
            tipo=Console.ReadLine();
        //Estructura de desición logica
            if (tipo == "1")
            {
                Console.WriteLine("Escribe la temperatura");
                Console.WriteLine("La tempertura de celsius a farenheit es: " + cambioTipoTemperaturaCelsius(total));
              
            }
            else if (tipo == "2")
            {
                Console.WriteLine("Escribe la temperatura");
                Console.WriteLine("La tempertura de farenheit a celsius es: " + cambioTipoTemperaturaFarenheit(total));

            }


            Console.ReadKey();
        }
        //Metodo de conversion de celsius a farenheit
        private static double cambioTipoTemperaturaCelsius(double total)
        {
            double  temperatura = 0;
            
           
             temperatura = double.Parse(Console.ReadLine());
             total = (temperatura * (9 / 5) + 32);


            return total;
        }
        //Metodo de conversion de farenheit a celsius
        private static double cambioTipoTemperaturaFarenheit(double total)
        {
            double temperatura = 0;
           
           
            temperatura = double.Parse(Console.ReadLine());
            total = (temperatura - 32) * 5 / 9;


            return total;
        }
    }
}
