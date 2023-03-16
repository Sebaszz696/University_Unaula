using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTallerPractico
{
    internal class ClsSextoPunto
    {
        public static void TablaDeMultiplicar()
        {
            double numero = 0;
            double multiplicador = 0;
            double total = 0;
            Console.WriteLine("Ingrese el numero para saber su tabla de multiplicar");
            Console.WriteLine("Si desea terminar ingrese '-1'");
            numero = Convert.ToDouble(Console.ReadLine());

            while (numero != -1)
            {
                 multiplicador = 1;

                while (multiplicador != 11)
                {
                    total = numero * multiplicador;

                    Console.WriteLine(numero+"*"+multiplicador+"= "+total);
                    multiplicador++;
                }

                Console.WriteLine("Ingresa un nuevo numero o si quieres terminar ingresa el -1");
                numero = Convert.ToInt16(Console.ReadLine());
            }

        }
    }
}
