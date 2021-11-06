using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox6.Text);
            double x = x0;
            textBox5.Text = "Работу выполнил ст. Марков Е." + Environment.NewLine;
            while (x <= (xk + dx / 2))
            {
                double y = Math.Pow(10, -1) * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                textBox5.Text += "x=" + Convert.ToString(x)  + "y=" + Convert.ToString(y) + Environment.NewLine;
                x += dx;
            }

           
        }

        private void Form1_Load(object senderx, EventArgs e)
        {
            textBox1.Text = "-0,5";
            textBox2.Text = "2,5";
            textBox3.Text = "0,05";
            textBox4.Text = "10,2";
            textBox6.Text = "1,25";

        }
    }
}
