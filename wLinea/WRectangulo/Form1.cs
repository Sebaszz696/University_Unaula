using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Fecha: Marzo 14 de 2023
/// Autor: Sebastian Velasquez
/// Descripción: Aplicación de Dibujar una linea
/// </summary>
namespace wLinea
{
    public partial class frmDibujarLinea : Form
    {

        public const int ancho = 20;
        public const int largo = 20;
        Graphics grafico;
    
        public frmDibujarLinea()
        {
            InitializeComponent();
            grafico = CreateGraphics();
           
        }

        private void btnDibujarLinea_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtx.Text);
                double y = double.Parse(txty.Text);

                double xFinal = double.Parse(txtXfinal.Text);
                double yFinal = double.Parse(txtYfinal.Text);

                ClsLinea line = new ClsLinea(x, y, xFinal, yFinal);


                Pen pen = new Pen(Color.FromArgb(255, 236, 0, 0));
     
                grafico.DrawLine(pen, line.obtenX(), line.obtenY(), line.obtenXFinal(), line.obtenYFinal());
                txtResultado.Text = Convert.ToString(ClsLinea.obtenCuenta());


            }
            catch
            { 

                MessageBox.Show("Digite un valor de tipo numérico");
            }
        }

     
    }
}
