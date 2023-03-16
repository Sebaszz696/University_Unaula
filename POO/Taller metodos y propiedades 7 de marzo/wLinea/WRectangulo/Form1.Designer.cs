namespace wLinea
{
    partial class frmDibujarLinea
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.X = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnDibujarLinea = new System.Windows.Forms.Button();
            this.txtYfinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXfinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(149, 63);
            this.X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(15, 16);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            // 
            // txtx
            // 
            this.txtx.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txtx.Location = new System.Drawing.Point(204, 63);
            this.txtx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(132, 22);
            this.txtx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y";
            // 
            // txty
            // 
            this.txty.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txty.Location = new System.Drawing.Point(204, 114);
            this.txty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(132, 22);
            this.txty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de Lineas";
            // 
            // txtResultado
            // 
            this.txtResultado.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txtResultado.Location = new System.Drawing.Point(325, 266);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(132, 22);
            this.txtResultado.TabIndex = 5;
            // 
            // btnDibujarLinea
            // 
            this.btnDibujarLinea.Location = new System.Drawing.Point(343, 167);
            this.btnDibujarLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDibujarLinea.Name = "btnDibujarLinea";
            this.btnDibujarLinea.Size = new System.Drawing.Size(137, 28);
            this.btnDibujarLinea.TabIndex = 6;
            this.btnDibujarLinea.Text = "Dibujar Linea";
            this.btnDibujarLinea.UseVisualStyleBackColor = true;
            this.btnDibujarLinea.Click += new System.EventHandler(this.btnDibujarLinea_Click);
            // 
            // txtYfinal
            // 
            this.txtYfinal.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txtYfinal.Location = new System.Drawing.Point(496, 114);
            this.txtYfinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtYfinal.Name = "txtYfinal";
            this.txtYfinal.Size = new System.Drawing.Size(132, 22);
            this.txtYfinal.TabIndex = 10;
//            this.txtYfinal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yfinal";
         //   this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtXfinal
            // 
            this.txtXfinal.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txtXfinal.Location = new System.Drawing.Point(496, 63);
            this.txtXfinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtXfinal.Name = "txtXfinal";
            this.txtXfinal.Size = new System.Drawing.Size(132, 22);
            this.txtXfinal.TabIndex = 8;
          //  this.txtXfinal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xfinal";
           // this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmDibujarLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtYfinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXfinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDibujarLinea);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.X);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDibujarLinea";
            this.Text = "Dibujar Rectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnDibujarLinea;
        private System.Windows.Forms.TextBox txtYfinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXfinal;
        private System.Windows.Forms.Label label4;
    }
}

