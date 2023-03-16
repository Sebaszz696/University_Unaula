using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTallerPractico
{
    internal class ClsTercerPunto
    {

        public static void Plano()
        {

            Console.WriteLine("Coordenada en x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coordenada y");
            double y = Convert.ToDouble(Console.ReadLine());

            Mostrar(x, y);
        }

        public static void Mostrar(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("(" + x + "," + y + ")" + " Estan en el primer cuadrante.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("(" + x + "," + y + ")" + " Estan en el segundo cuadrante.");

            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("(" + x + "," + y + ")" + " Estan en el tercer cuadrante.");

            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("(" + x + "," + y + ")" + " Estan en el cuarto cuadrante.");
            }
            else
            {
                Console.WriteLine("No sabemos en que cuadrante se encuentra dicho punto");
            }
            Console.ReadKey();
        }
    }
}
