namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.numero1 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "sumar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "restar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "multiplica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "dividir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(118, 49);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(163, 20);
            this.num1.TabIndex = 4;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(118, 104);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(162, 20);
            this.num2.TabIndex = 5;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(118, 166);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(161, 20);
            this.resultado.TabIndex = 6;
            this.resultado.TextChanged += new System.EventHandler(this.res_TextChanged);
            // 
            // numero1
            // 
            this.numero1.AutoSize = true;
            this.numero1.Location = new System.Drawing.Point(27, 51);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(51, 13);
            this.numero1.TabIndex = 7;
            this.numero1.Text = "numero 1";
            // 
            // numero2
            // 
            this.numero2.AutoSize = true;
            this.numero2.Location = new System.Drawing.Point(26, 107);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(51, 13);
            this.numero2.TabIndex = 8;
            this.numero2.Text = "numero 2";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(37, 169);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(50, 13);
            this.res.TabIndex = 9;
            this.res.Text = "resultado";
            this.res.Click += new System.EventHandler(this.resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 373);
            this.Controls.Add(this.res);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label numero1;
        private System.Windows.Forms.Label numero2;
        private System.Windows.Forms.Label res;
    }
}

