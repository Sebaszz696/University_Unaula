using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace wLinea
{
    class ClsLinea
    {
        private int x;
        private int y;
        private int xFinal;
        private int yFinal;


        private static int contar = 0;

        public ClsLinea()
        {
            x = 0;
            y = 0;
            xFinal = 0;
            yFinal = 0;

        }

        public ClsLinea(int x, int y, int xFinal, int yFinal)
        {
            this.x = x;
            this.y = y;
            this.xFinal = xFinal;
            this.yFinal = yFinal;
        }

        public ClsLinea(double x, double y, double xFinal, double yFinal)
        {
            this.x = (int)x;
            this.y = (int)y;
            this.xFinal = (int)xFinal;
            this.yFinal = (int)yFinal;
        }

        public int obtenX()
        {
            return x;
        }
        public int obtenXFinal()
        {
            return xFinal;
        }

        public int obtenY()
        {
            return y;
        }
        public int obtenYFinal()
        {
            return yFinal;
        }

        public void CambiarX(int x)
        {
            this.x = x;
        }
        public void CambiarY(int y)
        {
            this.y = y;
        }
        public void CambiarXFinal(int xFinal)
        {
            this.xFinal = xFinal;
        }
        public void CambiarYFinal(int yFinal)
        {
            this.yFinal = yFinal;
        }
        public static int obtenCuenta()
        {
            contar += 1;
            return contar;
        }


    }
}
