using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int res = num1 + num2;
            this.res.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int res = num1 - num2;
            this.res.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int res = num1 + num2;
            this.res.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);
            int res = num1 / num2;
            this.res.Text = resultado.ToString();
        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
        private void res_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
