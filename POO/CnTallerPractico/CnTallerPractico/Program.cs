using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CnTallerPractico
{/// <summary>
/// Sebastian Velasquez Perea
/// 24/02/2023
/// Los trabajos estan divididos por clases
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Trabajo();
        }
        private static void Trabajo () 
        { 
            Console.WriteLine("Hola bienvenido a mi taller practico escribe el numero del punto al cual quieres ir del 1 al 7");
            string punto = Console.ReadLine();
            if (punto == "1")
            {
                /*Primer punto*/
                ClsPrimerPunto.MayoriaEdad();

            }
            else if (punto == "2")
            {
                /*Segundo Punto*/
                ClsSegundoPunto.Triangulo();

            }
            else if (punto == "3")
            {
                /*Tercer Punto*/
                ClsTercerPunto.Plano();
            }
            else if (punto == "4")
            {
                /*Cuarto Punto*/
                ClsCuartoPunto.Cuadrado();
            }
            else if (punto == "5")
            {
                /*Quinto Punto*/
                ClsQuintoPunto.Empleado();
            }
            else if (punto == "6")
            {
                /*Sexto Punto*/
                ClsSextoPunto.TablaDeMultiplicar();
            }
            else if (punto == "7")
            {
                /*Septimo Punto */
                ClsSeptimoPunto.MayorMenor();
            }
            else
            {
                Console.WriteLine("Por favor escribe un numeor del 1 al 7");    
            }


            Console.WriteLine("Desea revisar otro punto?");
            Console.WriteLine("Escribe 1 si su respuesta es si de lo contrario presione cualquier tecla");
            string volver = Console.ReadLine();
            if (volver == "1")
            {
                Trabajo();
            }
            else
            {
                Console.WriteLine("Adios");
            }

        }
    }
}
